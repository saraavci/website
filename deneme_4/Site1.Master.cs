using Subgurim.Controles;
using Subgurim.Controles.GoogleChartIconMaker;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deneme_4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showOtel();
            showRestoran();
            showAtm();
            showCafe();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            showOtel();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            showRestoran();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            showAtm();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            showCafe();
        }

        private void showOtel()
        {

            PROJEEntities db = new PROJEEntities();
            var query = (from a in db.mekans
                         where a.tur == "otel"
                         select a.ad).ToList();


            GridView1.DataSource = query;
            GridView1.DataBind();


        }

        private void showRestoran()
        {
            PROJEEntities db = new PROJEEntities();
            var query = (from a in db.mekans
                         where a.tur == "restoran"
                         select a.ad).ToList();


            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        private void showAtm()
        {
            PROJEEntities db = new PROJEEntities();
            var query = (from a in db.mekans
                         where a.tur == "atm"
                         select a.ad).ToList();


            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        private void showCafe()
        {
            PROJEEntities db = new PROJEEntities();
            var query = (from a in db.mekans
                         where a.tur == "cafe"
                         select a.ad).ToList();


            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        protected void control(object sender, GridViewCommandEventArgs e)
        {
            PROJEEntities db = new PROJEEntities();

            if (e.CommandName == "cmd1")
            {
                int count = Convert.ToInt32(e.CommandArgument);
                count++;

                var query = (from a in db.mekans
                             where a.id == count
                             select a.location).SingleOrDefault();


                var y = Convert.ToDouble(query.Latitude);
                var x = Convert.ToDouble(query.Longitude);

                GMap1.Height = 1000;
                GMap1.Width = 1000;//500'dü ben 1000 yaptım
                GMap1.Key = "AIzaSyBbzayQWkhyVj3CTlFAh0UoVTt6NcZTpmo";
                var latlon = new GLatLng(x, y); //istenilen enlem boylam değerlerini merkez olarak alır
                GMap1.setCenter(latlon, 12);
                GMarker gm;
                GMarker icono = new GMarker(latlon);

                PinIcon p;
                p = new PinIcon(PinIcons.flag, Color.Red);  //istenen yere bırakılacak bayrak işaretçisi 
                gm = new GMarker(new GLatLng(Convert.ToDouble(x), Convert.ToDouble(y)), //parantezdeki sayılar enlem boylam buraya işaretçi bırakılacak
                         new GMarkerOptions(new GIcon(p.ToString(), p.Shadow())));
                GInfoWindow win;
                win = new GInfoWindow(gm, "" + "", false, GListener.Event.mouseover);  //haritaya eklenir
                GMap1.addInfoWindow(win);

            }
        }
    }
}