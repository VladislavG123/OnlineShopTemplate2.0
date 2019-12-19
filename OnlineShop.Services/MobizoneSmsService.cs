using OnlineShop.DTO;
using OnlineShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class MobizoneSmsService : ISmsService
    {
        public Task<SmsServiceResponseDTO> SendVerificationCode(string phoneNumber, string code)
        {
            /*string url = $"https://api.mobizon.kz/service/message/sendsmsmessage?" +
                $"recipient={phoneNumber}&text=Code: {code}" +
                $"&apiKey=kz739b92e1907f9680a0b71e3851ab59dcec2c26af77d8ee39876b18483fa5b232126f";*/

            string url = @"https://gvo_step2018@mail.ru:DZ2U3qmeA367DsXLyIPyDf1sfQHS@gate.smsaero.ru/v2/sms/send?number=+77073035370&text=Code 1231&sign=SMS Aero&channel=INTERNATIONAL";
        //    string url = $@"https://gvo_step2018@mail.ru:DZ2U3qmeA367DsXLyIPyDf1sfQHS@gate.smsaero.ru/v2/sms/send?number={phoneNumber}&text=Code {code}&sign=SMS Aero&channel=INTERNATIONAL";

            using (var webClient = new WebClient())
            {
                webClient.DownloadString(new Uri(url));
                var response = new SmsServiceResponseDTO();
            }

            return Task.FromResult(new SmsServiceResponseDTO { StatusCode = 200, Message = "Сообщение успешно отправлено" });
        }
    }
}