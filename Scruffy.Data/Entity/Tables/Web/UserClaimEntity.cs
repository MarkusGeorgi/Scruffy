﻿using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;

namespace Scruffy.Data.Entity.Tables.Web
{
    /// <summary>
    /// User claims
    /// </summary>
    [Table("UserClaims")]
    public class UserClaimEntity : IdentityUserClaim<long>
    {
    }
}