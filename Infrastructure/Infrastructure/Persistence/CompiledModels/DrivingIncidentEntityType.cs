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
    public partial class DrivingIncidentEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.DrivingIncident",
                typeof(DrivingIncident),
                baseEntityType,
                propertyCount: 17,
                navigationCount: 8,
                foreignKeyCount: 8,
                unnamedIndexCount: 7,
                keyCount: 1);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long),
                propertyInfo: typeof(DrivingIncident).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var collisionIndicator = runtimeEntityType.AddProperty(
                "CollisionIndicator",
                typeof(bool?),
                propertyInfo: typeof(DrivingIncident).GetProperty("CollisionIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<CollisionIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            collisionIndicator.AddAnnotation("Relational:DefaultValue", false);
            collisionIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var driverOwnershipIndicator = runtimeEntityType.AddProperty(
                "DriverOwnershipIndicator",
                typeof(bool?),
                propertyInfo: typeof(DrivingIncident).GetProperty("DriverOwnershipIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DriverOwnershipIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            driverOwnershipIndicator.AddAnnotation("Relational:DefaultValue", false);
            driverOwnershipIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drivingAccidentSeverityId = runtimeEntityType.AddProperty(
                "DrivingAccidentSeverityId",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingAccidentSeverityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingAccidentSeverityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            drivingAccidentSeverityId.AddAnnotation("Relational:DefaultValue", 1);
            drivingAccidentSeverityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drivingCmvid = runtimeEntityType.AddProperty(
                "DrivingCmvid",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingCmvid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingCmvid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            drivingCmvid.AddAnnotation("Relational:ColumnName", "DrivingCMVId");
            drivingCmvid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drivingHazMatId = runtimeEntityType.AddProperty(
                "DrivingHazMatId",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingHazMatId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingHazMatId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            drivingHazMatId.AddAnnotation("Relational:DefaultValue", 1);
            drivingHazMatId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drivingRoadCategoryId = runtimeEntityType.AddProperty(
                "DrivingRoadCategoryId",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingRoadCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingRoadCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            drivingRoadCategoryId.AddAnnotation("Relational:DefaultValue", 1);
            drivingRoadCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drivingRoadConditionId = runtimeEntityType.AddProperty(
                "DrivingRoadConditionId",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingRoadConditionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingRoadConditionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            drivingRoadConditionId.AddAnnotation("Relational:DefaultValue", 1);
            drivingRoadConditionId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drivingTrafficConditionId = runtimeEntityType.AddProperty(
                "DrivingTrafficConditionId",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingTrafficConditionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingTrafficConditionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            drivingTrafficConditionId.AddAnnotation("Relational:DefaultValue", 1);
            drivingTrafficConditionId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var drivingWeatherConditionId = runtimeEntityType.AddProperty(
                "DrivingWeatherConditionId",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingWeatherConditionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingWeatherConditionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            drivingWeatherConditionId.AddAnnotation("Relational:DefaultValue", 1);
            drivingWeatherConditionId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var legalSpeedRate = runtimeEntityType.AddProperty(
                "LegalSpeedRate",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("LegalSpeedRate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<LegalSpeedRate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            legalSpeedRate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var mobilePhoneIndicator = runtimeEntityType.AddProperty(
                "MobilePhoneIndicator",
                typeof(bool?),
                propertyInfo: typeof(DrivingIncident).GetProperty("MobilePhoneIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<MobilePhoneIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            mobilePhoneIndicator.AddAnnotation("Relational:DefaultValue", false);
            mobilePhoneIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var numberPedestrianInvolved = runtimeEntityType.AddProperty(
                "NumberPedestrianInvolved",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("NumberPedestrianInvolved", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<NumberPedestrianInvolved>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            numberPedestrianInvolved.AddAnnotation("Relational:DefaultValue", 0);
            numberPedestrianInvolved.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var passengerDescrption = runtimeEntityType.AddProperty(
                "PassengerDescrption",
                typeof(string),
                propertyInfo: typeof(DrivingIncident).GetProperty("PassengerDescrption", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<PassengerDescrption>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 555);
            passengerDescrption.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var passengerQuantity = runtimeEntityType.AddProperty(
                "PassengerQuantity",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("PassengerQuantity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<PassengerQuantity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            passengerQuantity.AddAnnotation("Relational:DefaultValue", 0);
            passengerQuantity.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var recordedSpeedRate = runtimeEntityType.AddProperty(
                "RecordedSpeedRate",
                typeof(int?),
                propertyInfo: typeof(DrivingIncident).GetProperty("RecordedSpeedRate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<RecordedSpeedRate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            recordedSpeedRate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var seatbeltUsedIndicator = runtimeEntityType.AddProperty(
                "SeatbeltUsedIndicator",
                typeof(bool?),
                propertyInfo: typeof(DrivingIncident).GetProperty("SeatbeltUsedIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<SeatbeltUsedIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            seatbeltUsedIndicator.AddAnnotation("Relational:DefaultValue", false);
            seatbeltUsedIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { activityId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK_DrivingIncident_1");

            var index = runtimeEntityType.AddIndex(
                new[] { drivingAccidentSeverityId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { drivingCmvid });

            var index1 = runtimeEntityType.AddIndex(
                new[] { drivingHazMatId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { drivingRoadCategoryId });

            var index3 = runtimeEntityType.AddIndex(
                new[] { drivingRoadConditionId });

            var index4 = runtimeEntityType.AddIndex(
                new[] { drivingTrafficConditionId });

            var index5 = runtimeEntityType.AddIndex(
                new[] { drivingWeatherConditionId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ActivityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ActivityId") }),
                principalEntityType,
                unique: true,
                required: true);

            var activity = declaringEntityType.AddNavigation("Activity",
                runtimeForeignKey,
                onDependent: true,
                typeof(Activity),
                propertyInfo: typeof(DrivingIncident).GetProperty("Activity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<Activity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var drivingIncident = principalEntityType.AddNavigation("DrivingIncident",
                runtimeForeignKey,
                onDependent: false,
                typeof(DrivingIncident),
                propertyInfo: typeof(Activity).GetProperty("DrivingIncident", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Activity).GetField("<DrivingIncident>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_DrivingIncident_DrivingIncident");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DrivingAccidentSeverityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("DrivingAccidentSeverityId") }),
                principalEntityType);

            var drivingAccidentSeverity = declaringEntityType.AddNavigation("DrivingAccidentSeverity",
                runtimeForeignKey,
                onDependent: true,
                typeof(DrivingAccidentSeverityDim),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingAccidentSeverity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingAccidentSeverity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var drivingIncidents = principalEntityType.AddNavigation("DrivingIncidents",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<DrivingIncident>),
                propertyInfo: typeof(DrivingAccidentSeverityDim).GetProperty("DrivingIncidents", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingAccidentSeverityDim).GetField("<DrivingIncidents>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_DrivingIncident_DrivingAccidentSeverityDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DrivingCmvid") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("DrivingCmvid") }),
                principalEntityType);

            var drivingCmv = declaringEntityType.AddNavigation("DrivingCmv",
                runtimeForeignKey,
                onDependent: true,
                typeof(DrivingCmvdim),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingCmv", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingCmv>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var drivingIncidents = principalEntityType.AddNavigation("DrivingIncidents",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<DrivingIncident>),
                propertyInfo: typeof(DrivingCmvdim).GetProperty("DrivingIncidents", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingCmvdim).GetField("<DrivingIncidents>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_DrivingIncident_DrivingCMVDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DrivingHazMatId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("DrivingHazMatId") }),
                principalEntityType);

            var drivingHazMat = declaringEntityType.AddNavigation("DrivingHazMat",
                runtimeForeignKey,
                onDependent: true,
                typeof(DrivingHazMatDim),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingHazMat", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingHazMat>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var drivingIncidents = principalEntityType.AddNavigation("DrivingIncidents",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<DrivingIncident>),
                propertyInfo: typeof(DrivingHazMatDim).GetProperty("DrivingIncidents", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingHazMatDim).GetField("<DrivingIncidents>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_DrivingIncident_DrivingHazMatDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey5(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DrivingRoadCategoryId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("DrivingRoadCategoryId") }),
                principalEntityType);

            var drivingRoadCategory = declaringEntityType.AddNavigation("DrivingRoadCategory",
                runtimeForeignKey,
                onDependent: true,
                typeof(DrivingRoadCategoryDim),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingRoadCategory", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingRoadCategory>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var drivingIncidents = principalEntityType.AddNavigation("DrivingIncidents",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<DrivingIncident>),
                propertyInfo: typeof(DrivingRoadCategoryDim).GetProperty("DrivingIncidents", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingRoadCategoryDim).GetField("<DrivingIncidents>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_DrivingIncident_DrivingRoadCategoryDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey6(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DrivingRoadConditionId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("DrivingRoadConditionId") }),
                principalEntityType);

            var drivingRoadCondition = declaringEntityType.AddNavigation("DrivingRoadCondition",
                runtimeForeignKey,
                onDependent: true,
                typeof(DrivingRoadConditionDim),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingRoadCondition", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingRoadCondition>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var drivingIncidents = principalEntityType.AddNavigation("DrivingIncidents",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<DrivingIncident>),
                propertyInfo: typeof(DrivingRoadConditionDim).GetProperty("DrivingIncidents", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingRoadConditionDim).GetField("<DrivingIncidents>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_DrivingIncident_DrivingRoadConditionDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey7(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DrivingTrafficConditionId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("DrivingTrafficConditionId") }),
                principalEntityType);

            var drivingTrafficCondition = declaringEntityType.AddNavigation("DrivingTrafficCondition",
                runtimeForeignKey,
                onDependent: true,
                typeof(DrivingTrafficConditionDim),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingTrafficCondition", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingTrafficCondition>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var drivingIncidents = principalEntityType.AddNavigation("DrivingIncidents",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<DrivingIncident>),
                propertyInfo: typeof(DrivingTrafficConditionDim).GetProperty("DrivingIncidents", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingTrafficConditionDim).GetField("<DrivingIncidents>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_DrivingIncident_DrivingTrafficConditionDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey8(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DrivingWeatherConditionId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("DrivingWeatherConditionId") }),
                principalEntityType);

            var drivingWeatherCondition = declaringEntityType.AddNavigation("DrivingWeatherCondition",
                runtimeForeignKey,
                onDependent: true,
                typeof(DrivingWeatherConditionDim),
                propertyInfo: typeof(DrivingIncident).GetProperty("DrivingWeatherCondition", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingIncident).GetField("<DrivingWeatherCondition>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var drivingIncidents = principalEntityType.AddNavigation("DrivingIncidents",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<DrivingIncident>),
                propertyInfo: typeof(DrivingWeatherConditionDim).GetProperty("DrivingIncidents", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(DrivingWeatherConditionDim).GetField("<DrivingIncidents>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_DrivingIncident_DrivingWeatherConditionDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "DrivingIncident");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
