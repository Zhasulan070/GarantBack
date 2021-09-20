using System;
using Newtonsoft.Json;

namespace GarantsBack.EF
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        [JsonIgnore] public string Password { get; set; }
        public bool Block { get; set; }
        [JsonIgnore] public bool SendEmail { get; set; }
        [JsonIgnore] public DateTime RegisterDate { get; set; }
        [JsonIgnore] public DateTime LastvisitDate { get; set; }
        public string Activation { get; set; }
        public string Params { get; set; }
        [JsonIgnore] public DateTime LastResetTime { get; set; }
        [JsonIgnore] public int ResetCount { get; set; }
        [JsonIgnore] public string OtpKey { get; set; }
        [JsonIgnore] public string Otep { get; set; }
        public bool RequireReset { get; set; }
        public int PositionId { get; set; }
        public int FilialId { get; set; }
        public int TeamId { get; set; }
    }
}