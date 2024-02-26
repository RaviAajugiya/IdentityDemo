﻿using System;
using System.Collections.Generic;

namespace IdentityDemo.TempModels;

public partial class EmployeeDemo
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public DateOnly? HireDate { get; set; }

    public decimal? Salary { get; set; }

    public bool IsActive { get; set; }
}
