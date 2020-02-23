using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosMiso.Model
{
    class DM_ChucNang
    {
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string root { get; set; }
        public string icon { get; set; }

        public DM_ChucNang(string _id, string _code, string _name, string _root, string _icon)
        {
            id = _id;
            code = _code;
            name = _name;
            root = _root;
            icon = _icon;
        }
    }
}
