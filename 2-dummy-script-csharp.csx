#!/usr/bin/env dotnet-script

#r "nuget: Newtonsoft.Json, 12.0.1"

using Newtonsoft.Json;
using System.Collections.Generic;

// TODO: talk to some external source of truth 

// get the inventory data into the right structure
var d = new Dictionary<string, object> {
	{"_meta", new Dictionary<string, object> {
		{"hostvars", new Dictionary<string, object> {
			{"192.168.33.19", new Dictionary<string, object> {
				{ "ansible_connection", "winrm" }, 
				{ "ansible_user", "vagrant" },
				{ "ansible_password", "vagrant" },
				{ "ansible_winrm_server_cert_validation", "ignore" },
			}}
		}}
	}},
	{"win", new Dictionary<string, object> {
	    {"hosts", new List<string> {"192.168.33.19"}}
	}},
};

// dump inventory structure as JSON to the console
Console.WriteLine(JsonConvert.SerializeObject(d, Formatting.Indented));

