using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

    [EnableCors("AllowAll")]
    public class Base64Hub : Hub
    {
        public async Task SendEncodedString(string encodedString)
        {
            var random = new Random();
            foreach (var c in encodedString)
            {
                await Clients.Caller.SendAsync("ReceiveCharacter", c);
                await Task.Delay(random.Next(1000, 5000));
            }
        }
    }

