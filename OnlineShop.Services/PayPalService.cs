using BraintreeHttp;
using OnlineShop.Domain;
using OnlineShop.DTO;
using OnlineShop.Services.Interfaces;
using PayPal.Core;
using PayPal.v1.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class PayPalService : IPaymentService
    {
        private const string APPROVAL_URL = "approval_url";

        public async Task<PaymentServiceResponseDTO> CreateInvoice(Domain.Order order)
        {
            var environment = new SandboxEnvironment("AZTu0aTctY3TsQRanLBGIjRYVhzo7rc25etnkVduypxV38zDdRja0Z6_adpN7nakww62w667wNh4_OKT", "EPT6TcCPEuAbNrCatN0_FyrWFTGtO6-1c77lhSj_pMrIx3o2V09BnpZnhLe3CfGO0wtW0IULHGI4yrGc");
            var client = new PayPalHttpClient(environment);

            int totalPrice = 0;
            foreach (var product in order.ProductsInOrder)
            {
                totalPrice += product.Product.Price;
            }

            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        ItemList = new ItemList(),
                        Amount = new Amount()
                        {
                            Total = totalPrice.ToString(),
                            Currency = "USD"
                        }
                    }

                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "https://example.com/cancel",
                    ReturnUrl = "https://example.com/return"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();
                return new PaymentServiceResponseDTO { PaymentUrl = result.Links.FirstOrDefault(link => link.Rel == APPROVAL_URL).Href };
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
                return null;
            }
        }
    }
}
