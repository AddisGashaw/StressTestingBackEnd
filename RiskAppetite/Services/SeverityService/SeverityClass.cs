using AutoMapper;
using Cbe.DomainException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiskAppetite.Models;
using RiskAppetite.Models.Dto.SeverityDto;
using RiskAppetite.Models.Dto.UserProfileDto;

namespace RiskAppetite.Services.SeverityService
{
    public class SeverityClass : ISeverity
    {
        private readonly IMapper _mapper;
        private readonly RiskApetiteContext _context;
        public SeverityClass(IMapper mapper, RiskApetiteContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ActionResult<string>> Register(SeverityCreateDto severityCreateDto)
        {
            try
            {
                var assignedUser = _mapper.Map<SeverityForAnalysis>(severityCreateDto);

                _context.SeverityForAnalyses.Add(assignedUser);
                await _context.SaveChangesAsync();

                // Retrieve the generated ID
                var generatedId = assignedUser.Id.ToString();


                // Return the generated form ID in the response
                return generatedId;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //public async Task<SeverityCreateDto> Register(SeverityCreateDto SeverityCreateDto)
        //{
            
        //    var AssignedUser = _mapper.Map<SeverityForAnalysis>(SeverityCreateDto);
        //    await _context.SeverityForAnalyses.AddAsync(AssignedUser);
        //    await _context.SaveChangesAsync();
        //    return SeverityCreateDto;
        //}


      
        public async Task<IEnumerable<SeverityReadDto>> GetSeverities()
        {
            if (_context.Severities == null)
            {
                throw new DataNotFoundException("Not Found");
            }
            var SeverityList = await _context.SeverityForAnalyses.Include(q => q.SeverityCat).ToListAsync();
            return _mapper.Map<IEnumerable<SeverityReadDto>>(SeverityList);
        }

        public async Task<IEnumerable<SeverityReadDto>> GetSeverityByYearAndQuarter(string year, string quarter, int id)
        {
            var severities = await _context.SeverityForAnalyses.Include(q=>q.SeverityCat)
                .Where(s => s.Year == year && s.Quarter == quarter && s.SeverityCatId==id)
                .ToListAsync();

            if (severities.Count == 0)
            {
                throw new DataNotFoundException($"No severities found for year {year} and quarter {quarter}.");
            }

            // var severityDetail = _mapper.Map<IEnumerable<SeverityReadDto>>(severities);
            return _mapper.Map<IEnumerable<SeverityReadDto>>(severities);
        }


        public async Task<ActionResult<SeverityReadDto>> GetSeverityById(int id)
        {

            var Severity = await _context.SeverityForAnalyses.FindAsync(id);
            if (Severity == null)
            {
                throw new DataNotFoundException("Severity with id =" + id + "is not found.");
            }
            //var Age = CalculateAge((DateTime)User.BirthDate);
            //User.Age = Age;
            Severity = await _context.SeverityForAnalyses.FirstOrDefaultAsync(c => c.Id == id);
            var SeverityDetail = _mapper.Map<SeverityReadDto>(Severity);
            return SeverityDetail;
        }



        private int GetQuarter(DateTime date)
        {
            return (date.Month - 1) / 3 + 1;
        }

        public async Task<SeverityCreateDto> UpdateSeverity(int id, SeverityCreateDto SeverityCreateDto)
        {
            var Severity = await _context.SeverityForAnalyses.FindAsync(id);
            if (Severity == null)
            {
                throw new DataNotFoundException("Severity with id =" + id + "is not found.");
            }

            Severity = _mapper.Map(SeverityCreateDto, Severity);
            _context.Entry(Severity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _mapper.Map<SeverityCreateDto>(Severity);
        }

        public async Task DeleteSeverity(int id)
        {
            var Severity = await _context.SeverityForAnalyses.FindAsync(id);
            if (Severity == null)
            {
                throw new DataNotFoundException("Severity with id= " + id + "is not found.");
            }

            _context.SeverityForAnalyses.Remove(Severity);
            await _context.SaveChangesAsync();
        }
    }
}
