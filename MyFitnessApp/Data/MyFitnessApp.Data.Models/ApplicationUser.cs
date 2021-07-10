﻿namespace MyFitnessApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;
    using MyFitnessApp.Data.Common.Models;

    using static MyFitnessApp.Common.DataConstants;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Foods = new HashSet<Food>();
            this.FoodDiaries = new HashSet<FoodDiary>();
            this.TrainingDiaries = new HashSet<TrainingDiary>();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.Articles = new HashSet<Article>();
        }

        [Required]
        [MaxLength(ApplicationUserFirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ApplicationUserLastNameMaxLength)]
        public string LastName { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }

        public Profile Profile { get; set; }

        public virtual ICollection<Food> Foods { get; set; }

        public virtual ICollection<Like> Likes { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Article> Articles { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<FoodDiary> FoodDiaries { get; set; }

        public virtual ICollection<TrainingDiary> TrainingDiaries { get; set; }

        public virtual ICollection<FollowerFollowee> Followers { get; set; }

        public virtual ICollection<FollowerFollowee> Followees { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
