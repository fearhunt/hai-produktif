using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCobaCoba
{
    class Data
    {
        public static string first_name, last_name, uname, Phone, Email;  //nanti bakal ditambah karena profil ga cuman itu hehe
        public static string e_name, e_authdate, e_desc, e_date, e_status, e_note; //data FormEvent
        public static string l_name, l_authdate, l_desc, l_deadline, l_contact, l_progress, l_note; //data FormLomba
        public static string lk_name, lk_authdate, lk_desc, lk_criteria, lk_status, lk_dateapplied, lk_note; //data 

        public void dataProfil(string fName, string lName, string email,string phone, string uName)
        {
            first_name = fName;
            last_name = lName;
            uname = uName;
            Email = email;
            Phone = phone;

        }

        //data tidak mungkin kosong karena sudah ada di dalam database semua
        public void Event(string eventName)
        {
            using (var db = new DBModel())
            {
                var query = (from events in db.Events where events.Name == eventName select events).FirstOrDefault();
                e_name = query.Name;
                e_authdate = "Oleh: " + query.Auth + " (" + (query.Published).ToString() + ")";
                e_desc = query.Desc;
                e_date = (query.Date).ToString();
                e_status = query.Status;
                e_note = query.Note;
                
            }
        }
        //using.System.Threading.Tasks
        //this.Close();
        //Thread th = new Thread(openSigUp) //method
        //Application.Run();
        //th.SetApartmentState(ApartmentState.STA)
        //    th.Start
        public void Lomba(string lombaName)
        {
            using (var db = new DBModel())
            {
                var query = (from lomba in db.Lomba where lomba.Name == lombaName select lomba).FirstOrDefault();
                l_name = query.Name;
                l_authdate = "Oleh: " + query.Auth + " (" + (query.Published).ToString() + ")";
                l_desc = query.Desc;
                l_deadline = (query.Deadline).ToString();
                l_contact = query.CP;
                //l_progress = query
                l_note = query.Note;
            }
        }

        public void Loker(string lokerName)
        {
            using (var db = new DBModel())
            {
                var query = (from loker in db.Loker where loker.Name == lokerName select loker).FirstOrDefault();
                lk_name = query.Name;
                lk_authdate = "Oleh: " + query.Auth + " (" + (query.Published).ToString() + ")";
                lk_desc = query.Desc;
                //lk_criteria = query.Criteria;
                lk_status = query.Status;
                lk_dateapplied = (query.Applied).ToString();
                lk_note = query.Note;
            }
        }
    }
}
