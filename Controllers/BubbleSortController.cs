using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BubbleSortMVC.Controllers
{
    public class BubbleSortController : Controller
    {
        // GET: BubbleSort
        public ActionResult Index()
        {
            int[] num = new int[10];

            Random random = new Random();
            for (int ctr = 0; ctr < num.Length; ctr++)
            {
                num[ctr] = random.Next(1, 100);
            }
            ViewBag.num = bubbleSort(num);
            return View();
        }
        int[] bubbleSort(int[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int ctr = 0; ctr < numbers.Length - 1; ctr++)
                {
                    if (numbers[ctr] > numbers[ctr + 1])
                    {
                        int temp = numbers[ctr + 1];
                        numbers[ctr + 1] = numbers[ctr];
                        numbers[ctr] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return numbers;

  
        }
    }

}