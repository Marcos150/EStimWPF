using EStimWPF.ProfilePageComponent.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStimWPF.profile.services
{
    internal class UserService
    {
        private Http<User> service;
        private string serviceURL;
        public UserService(string serviceURL)
        {
            service = new Http<User>();
            this.serviceURL = serviceURL;
        }
        public async Task<User[]?> GetUsers()
        {
            return await service.Get(this.serviceURL);
        }
        public async Task<User[]?> GetUserById(string id)
        {
            var user=await service.Get(this.serviceURL +"/"+ id);
            return user;
        }
        public async Task<User[]?> GetUserLogin()
        {
            var user = await service.Get(this.serviceURL + "/loginTest");
            return user;
        }
    }
}
