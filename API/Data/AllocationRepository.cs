using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;


namespace DatingApp.API.Data
{
    public class AllocationRepository : IAllocationRepository
    {
        
        private readonly DataContext _context;
        public AllocationRepository(DataContext context)
        {
            _context = context;

        }
        
        // public async Task<Allocation> RegisterAllocation (Allocation allocation, Dictionary<string, object> otherData )
        public async Task<Allocation> RegisterAllocation (Allocation allocation )
        {
            await _context.Allocations.AddAsync(allocation);
            await _context.SaveChangesAsync();
            return allocation;
        }
      
    }
}