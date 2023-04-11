using BakeryShop.Data;
using BakeryShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Net;
namespace BakeryShop.Pages
{
    public class OrderModel : PageModel
    {
        private readonly BakeryShopContext _db;
        public OrderModel(BakeryShopContext db) => this._db = db;
        public Product Product { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty,EmailAddress,Required(ErrorMessage = "Please Enter a valid Email"),Display(Name = "Your Email Address")]
        public string OrderEmail { get; set; }

        [BindProperty,Required(ErrorMessage = "Please supply a shipping address"),Display(Name = "Your Shipping Address")]
        public string OrderShipping { get; set; }

        [BindProperty,Display(Name ="Quantity")]
        public int OrderQuantity { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _db.Products.FindAsync(Id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Product = await _db.Products.FindAsync(Id);

            if (ModelState.IsValid)
            {
                //var body = $"<p>Thank You , We Recevied Your Order for  {OrderQuantity} of Piceces  of {Product?.Name}</p>" +
                //    $"<p>Your Addess is : {OrderShipping}</p>" +
                //    $"<p>Your Total Price is {OrderQuantity * Product?.Price}</p>" +
                //    "<p> <b>Your Order Will Delivered Within 60 Minutes</b> </p>";

                ////smtp object will be disposed after it goes out of its scope
                //using (var smtp = new SmtpClient())
                //{
                //    var googleCredential = new NetworkCredential()
                //    {
                //        UserName = "test11@gmail.com",       //enable 2-step-verification and use "App Password"
                //        Password = "app-password"
                //    };
                //    smtp.UseDefaultCredentials = false;
                //    smtp.Credentials = googleCredential;
                //    smtp.Host = "smtp.gmail.com";
                //    smtp.Port = 587;
                //    smtp.EnableSsl = true;
                //    var message = new MailMessage();
                //    message.To.Add(OrderEmail);
                //    message.Subject = "Fourth Coffee - New Order";
                //    message.Body = body;
                //    message.IsBodyHtml = true;
                //    message.From = new MailAddress("test22@gmail.com");
                //    await smtp.SendMailAsync(message);
                //}
                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
    }
}
