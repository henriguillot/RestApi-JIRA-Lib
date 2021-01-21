﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using JiraLib;

namespace Test6_Read_json_from_file
{
    class Program
    {
        static void Main(string[] args)
        {
            // read list-users .json ( contains JArray) 
            Tools.JsontArrayToString("List-users.json","t1.txt");

            // read list-users .json ( contains JObject) 
            Tools.JsontJObjectToString("List-users-from-group-toulon.json", "t3.txt");
        }
    }
}
