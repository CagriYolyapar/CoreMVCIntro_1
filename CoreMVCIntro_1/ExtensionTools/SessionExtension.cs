using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCIntro_1.ExtensionTools
{
    public static class SessionExtension
    {
        //Session["scart"]

        //Serialization => Bir yapının Json formata dönüstürülmesidir...

        //Deserialization =>  Bir Json formatın baska bir yapıya dönüstürülmesidir..


        //Session.SetObject("scart",cart);

        public static void SetObject(this ISession session,string key,object value)
        {
            string objectString = JsonConvert.SerializeObject(value); //burada bize gelen object degeri JSON formatta bir string'e cevirdik...
            session.SetString(key, objectString);
        }


        //Session'u geri almak lazım...Generic metotlar


        public static T GetObject<T>(this ISession session,string key) where T:class//(T bir referans tip olmak zorundadır)
        {
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString)) return null;
            T deserializedObject = JsonConvert.DeserializeObject<T>(objectString);
            return deserializedObject;
        }
    }
}
