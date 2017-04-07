using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolunteerApi.Data;
using VolunteerApi.Models;

namespace VolunteerApi.Controllers
{
 [Route("api/listings")]     
 public class ListingsController : Controller     
    {

            private readonly VolunteerContext db;
            
            public ListingsController(VolunteerContext context) {
                db = context;
            }
            //Support for the root collection of Quotes
            [HttpGet] 
            public IActionResult GetQuotes() 
                {  
                    return Ok(db.Listings); 
                }    

            //Support for getting a single quote by updating the Get Method    
            [HttpGet("{id}")]   
            public IActionResult Get(int id)   
                {    
                    return Ok(db.Listings.Find(id));  
                } 

            //Support for posting a Quote by updating the Post Method
            [HttpPost] 
            public IActionResult Post([FromBody] Listing listing) 
                {  
                    var newClaim = db.Listings.Add(listing);             
                    db.SaveChanges();             
                    return CreatedAtRoute("GetClaim", new { id = listing.Id }, listing); 
                }

            //Support for putting an existing quote back in the collection by updating Put Method
            [HttpPut("{id}")] 
            public IActionResult Put(int id, [FromBody] Listing listing) 
                {  
                     var newListing = db.Listings.Find(id);             
                     if (newListing == null) {                 
                         return NotFound();             
                     }       

                     newListing = listing;             
                     db.SaveChanges();             
                     return Ok(newListing);  
                } 


            [HttpDelete("{id}")] 
            public IActionResult Delete(int id) 
                {          
                    var listingToDelete = db.Listings.Find(id);             
                    if (listingToDelete == null) {                 
                        return NotFound();             
                    }             
                    db.Listings.Remove(listingToDelete);             
                    db.SaveChangesAsync();             
                    return NoContent(); 
                }   
    } 
}