using System.Net.Http;
using API.ApplicationDbContext;
using Data;
using GoogleMaps.LocationServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly BlazorDbContext _db;
        private const string ApiKey = "AIzaSyBahFaA4N8hj6Adpi1SqhYmGnKKObVWlmc";
        private const string BaseUrl = "http://api.openweathermap.org/data/2.5/weather";
        public ContactController(BlazorDbContext db, HttpClient httpClient)
        {
            _db = db;
            _httpClient = httpClient;
        }

    
        [HttpGet]
        public async Task<IActionResult> GetContact()
        {
            var result = await _db.contacts.ToListAsync();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ContactId = await _db.contacts.FindAsync(id);
            return Ok(ContactId);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Contact contact)
        {
            _db.contacts.Add(contact);
            await _db.SaveChangesAsync();
            return Ok(contact);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContact(int id, Contact contact)
        {
            var dbContact = await _db.contacts.FindAsync(id);
            if (dbContact is null)
            {
                return NotFound("Contact not found.");
            }

            dbContact.FirstName = contact.FirstName;
            dbContact.LastName = contact.LastName;
            dbContact.NickName = contact.NickName;
            dbContact.DateOfBirth = contact.DateOfBirth;
            dbContact.Place = contact.Place;
            dbContact.DateUpdated = DateTime.Now;

            _db.contacts.Update(dbContact);
            await _db.SaveChangesAsync();

            return Ok(contact);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Contact>>> DeleteContact(int id)
        {
            var dbContact = await _db.contacts.FindAsync(id);
            if (dbContact is null)
            {
                return NotFound("Contact not found.");
            }
            dbContact.IsDeleted = true;
            dbContact.DateDeleted = DateTime.Now;
            _db.contacts.Remove(dbContact);
            await _db.SaveChangesAsync();

            return Ok();
        }


        [HttpGet("map")]
        public async Task<ActionResult<List<Contact>>> GetMapContacts()
        {
            return await _db.contacts
                .Where(c => !c.IsDeleted && c.Latitude != null && c.Longitude != null)
                .ToListAsync();
        }

        MapPoint? GetLatLong(Contact contact)
        {
            var gls = new GoogleLocationService("AIzaSyBahFaA4N8hj6Adpi1SqhYmGnKKObVWlmc");
            var LatLong = gls.GetLatLongFromAddress(contact.Place);
            return LatLong;
        }

        void SetLatLong(Contact contact)
        {
            var latLong = GetLatLong(contact);
            if (latLong != null)
            {
                contact.Latitude = latLong.Latitude;
                contact.Longitude = latLong.Longitude;
            }
        }



    }
}
