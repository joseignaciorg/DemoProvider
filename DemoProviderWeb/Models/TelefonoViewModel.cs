using System;
using Microsoft.SharePoint.Client;

namespace DemoProviderWeb.Models
{
    public class TelefonoViewModel
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Numero { get; set; }

        public static TelefonoViewModel FromListItem(ListItem item)
        {
            var data=new TelefonoViewModel();
            var id = item["ID"].ToString();
            var ido = 0;//inicializo ido para usarlo despues
            int.TryParse(id, out ido);//el id lo transformo en un entero y lo guardo en ido poniendole el out
            data.Id = ido;
            data.Nombre = item["Title"].ToString();
            data.Numero = item["Numero"].ToString();
            return data;
        } 
    }
}