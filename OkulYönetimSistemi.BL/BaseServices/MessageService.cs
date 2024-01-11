using System;
using System.Collections.Generic;

namespace OkulYönetimSistemi.BL.BaseServices
{
    //daha çok durum kontrolü için burayı kullanacağız,oldu mu olmadı mı gibi
    public class MessageService
    {
        public int ResultID { get; set; }
        public string Message { get; set; }

        public bool IsSuccess
        {
            get
            {
                if (ResultID > 0)
                {
                    return true;
                }
                return false;
            }
        } // control KD
    }
}