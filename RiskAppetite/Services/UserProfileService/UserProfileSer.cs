using AutoMapper;
using Cbe.DomainException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiskAppetite.Models;
using RiskAppetite.Models.Dto.UserProfileDto;

namespace RiskAppetite.Services.UserProfileService
{
    public class UserProfileSer : IUserProfile
    {
        private readonly IMapper _mapper;
        private readonly RiskApetiteContext _context;

        public UserProfileSer(RiskApetiteContext context, IMapper mapper)
        {
           _context = context;
            _mapper = mapper;
        }
        public async Task<userProfileUpdateDto> Register(userProfileUpdateDto userProfileUpdateDto)
        {
            if (_context.UserProfiles.Any(u => u.EmployeeId == userProfileUpdateDto.EmployeeId || u.UserEmail == userProfileUpdateDto.UserEmail))
            {
                throw new DataNotFoundException("User Already exists.");
            }
            var AssignedUser = _mapper.Map<UserProfile>(userProfileUpdateDto);
            await _context.UserProfiles.AddAsync(AssignedUser);
            await _context.SaveChangesAsync();
            return userProfileUpdateDto;
        }
        public async Task<IEnumerable<userProfileReadOnlyDto>> GetUserProfiles()
        {
            if (_context.UserProfiles == null)
            {
                throw new DataNotFoundException("Not Found");
            }
            var UserProfileDetail = await _context.UserProfiles.Include(q => q.UserRole).ToListAsync();
            return _mapper.Map<IEnumerable<userProfileReadOnlyDto>>(UserProfileDetail);
        }
        public async Task<ActionResult<userProfileReadOnlyDto>> GetUserProfilebyId(int id)
        {

            var User = await _context.UserProfiles.FindAsync(id);
            if (User == null)
            {
                throw new DataNotFoundException("User with id =" + id + "is not found.");
            }
            //var Age = CalculateAge((DateTime)User.BirthDate);
            //User.Age = Age;
            User = await _context.UserProfiles.Include(q => q.UserRole).FirstOrDefaultAsync(c => c.Id == id);
            var userDetail = _mapper.Map<userProfileReadOnlyDto>(User);
            return userDetail;
        }
        public async Task<userProfileUpdateDto> UpdateUserProfile(int id, userProfileUpdateDto userProfileUpdateDto)
        {
            var User = await _context.UserProfiles.FindAsync(id);
            if (User == null)
            {
                throw new DataNotFoundException("User with id =" + id + "is not found.");
            }

            User = _mapper.Map(userProfileUpdateDto, User);
            _context.Entry(User).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _mapper.Map<userProfileUpdateDto>(User);
        }
        public async Task DeleteUserDetail(int id)
        {
            var user = await _context.UserProfiles.FindAsync(id);
            if (user == null)
            {
                throw new DataNotFoundException("User with id= " + id + "is not found.");
            }

            _context.UserProfiles.Remove(user);
            await _context.SaveChangesAsync();
        }
        

    }
}
