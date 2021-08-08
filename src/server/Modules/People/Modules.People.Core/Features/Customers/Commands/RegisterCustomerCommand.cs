﻿// <copyright file="RegisterCustomerCommand.cs" company="Fluentpos">
// --------------------------------------------------------------------------------------------------
// Copyright (c) Fluentpos. All rights reserved.
// The core team: Mukesh Murugan (iammukeshm), Chhin Sras (chhinsras), Nikolay Chebotov (unchase).
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// --------------------------------------------------------------------------------------------------
// </copyright>

using System;
using FluentPOS.Shared.Core.Wrapper;
using FluentPOS.Shared.DTOs.Upload;
using MediatR;

namespace FluentPOS.Modules.People.Core.Features.Customers.Commands
{
    public class RegisterCustomerCommand : IRequest<Result<Guid>>
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string ImageUrl { get; set; }

        public string Type { get; set; }

        public UploadRequest UploadRequest { get; set; }
    }
}