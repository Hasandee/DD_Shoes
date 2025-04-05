using DD_Shoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace DD_Shoes.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            IEnumerable<mvcProductModel> productlist;
            HttpResponseMessage response = GlobalVariables.WebClient.GetAsync("Product").Result;
            productlist = response.Content.ReadAsAsync<IEnumerable<mvcProductModel>>().Result;
                return View(productlist);
        }
        public ActionResult AddOrEdit(int id = 0)
        {
            if(id==0)
            return View(new mvcProductModel());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebClient.GetAsync("Product/"+id.ToString( )).Result;
                return View(response.Content.ReadAsAsync<mvcProductModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcProductModel product)
        {
            if (product.Product_ID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebClient.PostAsJsonAsync("Product", product).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebClient.PutAsJsonAsync("Product/"+product.Product_ID, product).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebClient.DeleteAsync("Product/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}