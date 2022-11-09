using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Newproj.BAL
{
    public class RegBAL
    {
        //create object pf dataAccess layer
        DAL.RegDAL objdeptdl = new DAL.RegDAL();
        //create two variables based on table
        private string _stud_name;
        private string _student_id;
        private string _student_email;
        private string _student_phone;
        private string _student_gender;
        private string _student_courses;
        private string _student_dob;
        private string _student_lid;
        private string _student_username;
        private string _student_pass;
        private string _username;
        private string _pass;
        private object _ob;
        private string _fac_name;
        private string _fac_id;
        private string _fac_email;
        private string _fac_phone;
        private string _fac_gender;
        private string _fac_clg;
        private string _fac_dob;
        private string _fac_lid;
        private string _fac_username;
        private string _fac_pass;
        private object _ob_fac;


        public string studname
        {
            get
            {
                return _stud_name;
            }
            set
            {
                _stud_name = value;
            }
        }

        public string studid
        {
            get
            {
                return _student_id;
            }
            set
            {
                _student_id = value;
            }
        }
        public string studemail
        {
            get
            {
                return _student_email;
            }
            set
            {
                _student_email = value;
            }
        }
        public string studphone
        {
            get
            {
                return _student_phone;
            }
            set
            {
                _student_phone = value;
            }
        }


        public string studgender
        {
            get
            {
                return _student_gender;
            }
            set
            {
                _student_gender = value;
            }
        }
        public string studcourse
        {
            get
            {
                return _student_courses;
            }
            set
            {
                _student_courses = value;
            }
        }

        public string studdob
        {
            get
            {
                return _student_dob;
            }
            set
            {
                _student_dob = value;
            }
        }
        public string studusername
        {
            get
            {
                return _student_username;
            }
            set
            {
                _student_username = value;
            }
        }
        public string studpasswd
        {
            get
            {
                return _student_pass;
            }
            set
            {
                _student_pass = value;
            }
        }

        public string studlid
        {
            get
            {
                return _student_lid;
            }
            set
            {
                _student_lid = value;
            }
        }
       
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string password
        {
            get
            {
                return _pass;
            }
            set
            {
                _pass = value;
            }
        }

        public object id
        {
            get
            {
                return _ob;
            }
            set
            {
                _ob = value;
            }
        }

        public string facname
        {
            get
            {
                return _fac_name;
            }
            set
            {
                _fac_name = value;
            }
        }

        public string facid
        {
            get
            {
                return _fac_id;
            }
            set
            {
                _fac_id = value;
            }
        }
        public string facemail
        {
            get
            {
                return _fac_email;
            }
            set
            {
                _fac_email = value;
            }
        }
        public string facphone
        {
            get
            {
                return _fac_phone;
            }
            set
            {
                _fac_phone = value;
            }
        }


        public string facgender
        {
            get
            {
                return _fac_gender;
            }
            set
            {
                _fac_gender = value;
            }
        }
        public string faccollege
        {
            get
            {
                return _fac_clg;
            }
            set
            {
                _fac_clg = value;
            }
        }

        public string facdob
        {
            get
            {
                return _fac_dob;
            }
            set
            {
                _fac_dob = value;
            }
        }
        public string facusername
        {
            get
            {
                return _fac_username;
            }
            set
            {
                _fac_username = value;
            }
        }
        public string facpasswd
        {
            get
            {
                return _fac_pass;
            }
            set
            {
                _fac_pass = value;
            }
        }

        public string faclid
        {
            get
            {
                return _fac_lid;
            }
            set
            {
                _fac_lid = value;
            }
        }

        public object facob
        {
            get
            {
                return _ob_fac;
            }
            set
            {
                _ob_fac = value;
            }
        }



        public object stud_login_insert()
        {
            return objdeptdl.userlogin(this);
        }
        public int student_reg()
        {
            return objdeptdl.stud_reg(this);
        }


        public DataTable viewusers()
        {
          return objdeptdl.view_users();
        }


        public int confirmuser()
        {
            return objdeptdl.Confirm_user(this);
        }

        public int userlogin()
        {
            return objdeptdl.User_login(this);
        }

        public object fac_login_insert()
        {
            return objdeptdl.faclogin(this);
        }

        public int fac_reg()
        {
            return objdeptdl.faculty_reg(this);
        }
        public DataTable viewfacusers()
        {
            return objdeptdl.fac_view_users();
        }

        public int confirmfacuser()
        {
            return objdeptdl.Confirm_fac_user(this);
        }
    }
}