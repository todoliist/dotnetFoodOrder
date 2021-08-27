using Mango.Web.Models;
using Mango.Web.Services.IServices;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mango.Web.Services
{
    public class CouponService : BaseService,ICouponService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CouponService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<T> GetCoupon<T>(string CouponCode, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/" + CouponCode,
                AccessToken = token
            });
        }
    }
}
