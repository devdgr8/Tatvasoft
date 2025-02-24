﻿using BackEnd.BAL;
using BackEnd.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientMissionController : ControllerBase
    {
        private readonly BALMission _balMission;
        ResponseResult result = new ResponseResult();        
        public ClientMissionController(BALMission balMission)
        {
            _balMission = balMission;          
        }
        [HttpGet]
        [Route("ClientSideMissionList/{userId}")]
        public ResponseResult ClientSideMissionList(int userId)
        {
            try
            {
                result.Data = _balMission.ClientSideMissionList(userId);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("MissionClientList")]
        public ResponseResult MissionClientList(SortestData data)
        {
            try
            {
                result.Data = _balMission.MissionClientList(data);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("ApplyMission")]
        public ResponseResult ApplyMission(MissionApplication missionApplication)
        {
            try
            {
                result.Data = _balMission.ApplyMission(missionApplication);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("MissionDetailByMissionId")]
        [Authorize]
        public ResponseResult MissionDetailByMissionId(SortestData data)
        {
            try
            {
                result.Data = _balMission.MissionDetailByMissionId(data);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpPost]
        [Route("AddMissionComment")]
        public ResponseResult AddMissionComment(MissionComment missionComment)
        {
            try
            {
                result.Data = _balMission.AddMissionComment(missionComment);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpGet]
        [Route("MissionCommentListByMissionId/{missionId}")]
        public ResponseResult MissionCommentListByMissionId(int missionId)
        {
            try
            {
                result.Data = _balMission.MissionCommentListByMissionId(missionId);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpPost]
        [Route("AddMissionFavourite")]
        public ResponseResult AddMissionFavourite(MissionFavourites missionFavourites)
        {
            try
            {
                result.Data = _balMission.AddMissionFavourite(missionFavourites);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpPost]
        [Route("RemoveMissionFavourite")]        
        public ResponseResult RemoveMissionFavourite(MissionFavourites missionFavourites)
        {
            try
            {
                result.Data = _balMission.RemoveMissionFavourite(missionFavourites);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpPost]
        [Route("MissionRating")]
        public ResponseResult MissionRating(MissionRating missionRating)
        {
            try
            {
                result.Data = _balMission.MissionRating(missionRating);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpPost]
        [Route("RecentVolunteerList")]
        public ResponseResult RecentVolunteerList(MissionApplication missionApplication)
        {
            try
            {
                result.Data = _balMission.RecentVolunteerList(missionApplication);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpGet]
        [Route("GetUserList/{userId}")]
        public ResponseResult GetUserList(int userId)
        {
            try
            {
                result.Data = _balMission.GetUserList(userId);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpPost]
        [Route("SendInviteMissionMail")]
        public ResponseResult SendInviteMissionMail(List<MissionShareOrInvite> user)
        {
            try
            {
                result.Data = _balMission.SendInviteMissionMail(user);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
