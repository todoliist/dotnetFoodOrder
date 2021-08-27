using Mango.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Web.Services.IServices
{
    public interface ICouponService
    {
        Task<T> GetCoupon<T>(string CouponCode, string token = null);
    }
}
