using Domain.Entities;
using Domain.IRepositories;
using Infrastructure.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) 
        { 
            _context = context;
        }

        public async Task AddAsync(User user)
        { 
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetByEmailAsync(string email) 
        { 
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }
        public void Add(User obj)
        {
            throw new NotImplementedException();
        }

        public List<User> FindAll()
        {
            throw new NotImplementedException();
        }

        public User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByEmail(string email)
        {
             
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
