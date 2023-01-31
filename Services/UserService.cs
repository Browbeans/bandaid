using bandaid.Data;
using bandaid.interfaces;
using bandaid.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 


namespace bandaid.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;
        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ActionResult<List<Ad>>> GetUserAsync()
        {
            return await _dataContext.Ads.ToListAsync();
        }
    };   
}
