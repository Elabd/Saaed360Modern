﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class EscortMissionPatrolEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.EscortMissionPatrol",
                typeof(EscortMissionPatrol),
                baseEntityType,
                propertyCount: 9,
                navigationCount: 5,
                foreignKeyCount: 2,
                unnamedIndexCount: 2,
                keyCount: 1);

            var escortMissionPatrolId = runtimeEntityType.AddProperty(
                "EscortMissionPatrolId",
                typeof(long),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("EscortMissionPatrolId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<EscortMissionPatrolId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            escortMissionPatrolId.AddAnnotation("Relational:ColumnName", "EscortMissionPatrolID");
            escortMissionPatrolId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var creationDateTime = runtimeEntityType.AddProperty(
                "CreationDateTime",
                typeof(DateTime),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("CreationDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<CreationDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            creationDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            creationDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var currentMissionPatrolStepId = runtimeEntityType.AddProperty(
                "CurrentMissionPatrolStepId",
                typeof(int?),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("CurrentMissionPatrolStepId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<CurrentMissionPatrolStepId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            currentMissionPatrolStepId.AddAnnotation("Relational:ColumnName", "CurrentMissionPatrolStepID");
            currentMissionPatrolStepId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var escortMissionId = runtimeEntityType.AddProperty(
                "EscortMissionId",
                typeof(long),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("EscortMissionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<EscortMissionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            escortMissionId.AddAnnotation("Relational:ColumnName", "EscortMissionID");
            escortMissionId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isPatrolUsed = runtimeEntityType.AddProperty(
                "IsPatrolUsed",
                typeof(bool),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("IsPatrolUsed", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<IsPatrolUsed>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: true);
            isPatrolUsed.AddAnnotation("Relational:DefaultValue", true);
            isPatrolUsed.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifictionDateTime = runtimeEntityType.AddProperty(
                "ModifictionDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("ModifictionDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<ModifictionDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modifictionDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            modifictionDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var notes = runtimeEntityType.AddProperty(
                "Notes",
                typeof(string),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("Notes", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<Notes>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 4000);
            notes.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolId = runtimeEntityType.AddProperty(
                "PatrolId",
                typeof(long),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("PatrolId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<PatrolId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            patrolId.AddAnnotation("Relational:ColumnName", "PatrolID");
            patrolId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var timeStamp = runtimeEntityType.AddProperty(
                "TimeStamp",
                typeof(byte[]),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("TimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<TimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                concurrencyToken: true,
                valueGenerated: ValueGenerated.OnAddOrUpdate,
                beforeSaveBehavior: PropertySaveBehavior.Ignore,
                afterSaveBehavior: PropertySaveBehavior.Ignore);
            timeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { escortMissionPatrolId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK_EscortPatrols");

            var index = runtimeEntityType.AddIndex(
                new[] { escortMissionId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { patrolId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("EscortMissionId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("EscortMissionId") }),
                principalEntityType,
                required: true);

            var escortMission = declaringEntityType.AddNavigation("EscortMission",
                runtimeForeignKey,
                onDependent: true,
                typeof(EscortMission),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("EscortMission", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<EscortMission>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var escortMissionPatrols = principalEntityType.AddNavigation("EscortMissionPatrols",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EscortMissionPatrol>),
                propertyInfo: typeof(EscortMission).GetProperty("EscortMissionPatrols", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMission).GetField("<EscortMissionPatrols>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_EscortMissionPatrols_EscortMissions");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PatrolId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ItemId") }),
                principalEntityType,
                required: true);

            var patrol = declaringEntityType.AddNavigation("Patrol",
                runtimeForeignKey,
                onDependent: true,
                typeof(Item),
                propertyInfo: typeof(EscortMissionPatrol).GetProperty("Patrol", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EscortMissionPatrol).GetField("<Patrol>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var escortMissionPatrols = principalEntityType.AddNavigation("EscortMissionPatrols",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EscortMissionPatrol>),
                propertyInfo: typeof(Item).GetProperty("EscortMissionPatrols", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Item).GetField("<EscortMissionPatrols>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_EscortMissionPatrol_Item");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "EscortMissionPatrol");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
