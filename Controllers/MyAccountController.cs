using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolunteerApi.Data;
using VolunteerApi.Models;

namespace VolunteerApi.Controllers
{
 [Route("api/myaccount")]     
 public class MyAccountController : Controller     
    {

            private readonly VolunteerContext db;
            
            public MyAccountController(VolunteerContext context) {
                db = context;
            }
            //Support for the root collection of Quotes
            [HttpGet] 
            public IActionResult GetAccounts() 
                {  
                    return Ok(db.Accounts); 
                }    

            //Support for getting a single quote by updating the Get Method    
            [HttpGet("{id}")]   
            public IActionResult Get(int id)   
                {    
                    return Ok(db.Accounts.Find(id));  
                } 

            //Support for posting a Quote by updating the Post Method
            [HttpPost] 
            public IActionResult Post([FromBody] Account account) 
                {  
                    var newAccount = db.Accounts.Add(account);             
                    db.SaveChanges();             
                    return CreatedAtRoute("GetAccount", new { id = account.Id }, account); 
                }

            //Support for putting an existing quote back in the collection by updating Put Method
            [HttpPut("{id}")] 
            public IActionResult Put(int id, [FromBody] Account account) 
                {  
                     var newAccount = db.Accounts.Find(id);             
                     if (newAccount == null) {                 
                         return NotFound();             
                     }       

                     newAccount = account;             
                     db.SaveChanges();             
                     return Ok(newAccount);  
                } 


            [HttpDelete("{id}")] 
            public IActionResult Delete(int id) 
                {          
                    var accountToDelete = db.Accounts.Find(id);             
                    if (accountToDelete == null) {                 
                        return NotFound();             
                    }             
                    db.Accounts.Remove(accountToDelete);             
                    db.SaveChangesAsync();             
                    return NoContent(); 
                }   
    } 
}