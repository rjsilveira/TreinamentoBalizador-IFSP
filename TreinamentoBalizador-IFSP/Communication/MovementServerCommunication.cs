﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

using TreinamentoBalizador_IFSP.Models;


namespace TreinamentoBalizador_IFSP.Communication
{
    class MovementServerCommunication
    {
        public Boolean VerifyMovement(FormatedCoordinatesModel formatedCoordinates)
        {
            String endPoint = "verify-movement";
            
            var request = (HttpWebRequest)WebRequest.Create(Utils.Constant.URL + endPoint);
            request.ContentType = "application/json";
            request.Method = "POST";

            bool result = false;
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                var json = new JavaScriptSerializer().Serialize(formatedCoordinates);
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

            }

            var response = (HttpWebResponse)request.GetResponse();

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                result = Boolean.Parse(streamReader.ReadToEnd());
            }

            return result;
        }

        public Boolean SaveMovement(FormatedCoordinatesModel formatedCoordinates)
        {
            String endPoint = "save-movement";
            
            var request = (HttpWebRequest)WebRequest.Create(Utils.Constant.URL + endPoint);
            request.ContentType = "application/json";
            request.Method = "POST";

            bool result = false;
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                var json = new JavaScriptSerializer().Serialize(formatedCoordinates);
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

            }

            var response = (HttpWebResponse)request.GetResponse();

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                HttpStatusCode statusCode = ((HttpWebResponse)response).StatusCode;
                if (statusCode.ToString() == "OK")
                {
                    result = true;
                }
            }

           
            return result;
        }


    }
}
