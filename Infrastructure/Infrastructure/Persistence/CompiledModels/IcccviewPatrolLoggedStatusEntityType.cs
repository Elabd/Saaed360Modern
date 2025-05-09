﻿// <auto-generated />
using System;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class IcccviewPatrolLoggedStatusEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.IcccviewPatrolLoggedStatus",
                typeof(IcccviewPatrolLoggedStatus),
                baseEntityType,
                propertyCount: 3);

            var loggedIn = runtimeEntityType.AddProperty(
                "LoggedIn",
                typeof(bool?),
                propertyInfo: typeof(IcccviewPatrolLoggedStatus).GetProperty("LoggedIn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccviewPatrolLoggedStatus).GetField("<LoggedIn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            loggedIn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolCode = runtimeEntityType.AddProperty(
                "PatrolCode",
                typeof(string),
                propertyInfo: typeof(IcccviewPatrolLoggedStatus).GetProperty("PatrolCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccviewPatrolLoggedStatus).GetField("<PatrolCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            patrolCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolId = runtimeEntityType.AddProperty(
                "PatrolId",
                typeof(long),
                propertyInfo: typeof(IcccviewPatrolLoggedStatus).GetProperty("PatrolId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccviewPatrolLoggedStatus).GetField("<PatrolId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            patrolId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "ICCCViewPatrolLoggedStatus");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
