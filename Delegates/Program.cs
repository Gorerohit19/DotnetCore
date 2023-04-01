using System;
using SimpleDelegatesDemo;

double amount = 5000;

TaxHandler hander = new TaxHandler(Controller.PayIncomeTax);
Dispatcher emailDispatcher = new Dispatcher(Controller.SendEmail);
Dispatcher smsDispacher = new Dispatcher(Controller.SendSMS);

hander.Invoke(amount);

emailDispatcher.Invoke("gorerohit1902@gmail.com", "Hi Rohit");
smsDispacher.Invoke("7378982802","Hi Rohit this message is from Bank");