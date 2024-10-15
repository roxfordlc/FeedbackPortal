using API.Data;
using API.DTOs;
using API.Entities;
using API.Helpers;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class FeedbackController(IUnitOfWork unitOfWork, IMapper mapper) : BaseApiController
    {
        [Authorize]
        [HttpGet]
        public async Task<IEnumerable<FeedbackDto>> GetReceivedFeedbackForUser([FromQuery]FeedbackParams feedbackParams)
        {
            return await unitOfWork.FeedbackRepository.GetReceivedFeedbackForUser(feedbackParams);
        }  

        [HttpPost]
        public async Task<ActionResult<FeedbackDto>> CreateFeedback(CreateFeedbackDto createFeedbackDto)
        {
            throw new NotImplementedException();
        }
    }


}
