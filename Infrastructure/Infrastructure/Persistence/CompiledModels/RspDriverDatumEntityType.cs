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
    public partial class RspDriverDatumEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.RspDriverDatum",
                typeof(RspDriverDatum),
                baseEntityType,
                propertyCount: 14,
                navigationCount: 5,
                foreignKeyCount: 5,
                unnamedIndexCount: 5,
                keyCount: 1);

            var rspDriverDataId = runtimeEntityType.AddProperty(
                "RspDriverDataId",
                typeof(long),
                propertyInfo: typeof(RspDriverDatum).GetProperty("RspDriverDataId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<RspDriverDataId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            rspDriverDataId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var createdDateTime = runtimeEntityType.AddProperty(
                "CreatedDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(RspDriverDatum).GetProperty("CreatedDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<CreatedDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            createdDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            createdDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var driverName = runtimeEntityType.AddProperty(
                "DriverName",
                typeof(string),
                propertyInfo: typeof(RspDriverDatum).GetProperty("DriverName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<DriverName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200,
                unicode: false);
            driverName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var genderId = runtimeEntityType.AddProperty(
                "GenderId",
                typeof(int?),
                propertyInfo: typeof(RspDriverDatum).GetProperty("GenderId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<GenderId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            genderId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isActive = runtimeEntityType.AddProperty(
                "IsActive",
                typeof(bool?),
                propertyInfo: typeof(RspDriverDatum).GetProperty("IsActive", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<IsActive>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isActive.AddAnnotation("Relational:DefaultValue", false);
            isActive.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDriverHasNoLicense = runtimeEntityType.AddProperty(
                "IsDriverHasNoLicense",
                typeof(bool?),
                propertyInfo: typeof(RspDriverDatum).GetProperty("IsDriverHasNoLicense", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<IsDriverHasNoLicense>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isDriverHasNoLicense.AddAnnotation("Relational:DefaultValue", false);
            isDriverHasNoLicense.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var licenseCategoryId = runtimeEntityType.AddProperty(
                "LicenseCategoryId",
                typeof(int?),
                propertyInfo: typeof(RspDriverDatum).GetProperty("LicenseCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<LicenseCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            licenseCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var licenseNumber = runtimeEntityType.AddProperty(
                "LicenseNumber",
                typeof(string),
                propertyInfo: typeof(RspDriverDatum).GetProperty("LicenseNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<LicenseNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            licenseNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var licenseSourceId = runtimeEntityType.AddProperty(
                "LicenseSourceId",
                typeof(int?),
                propertyInfo: typeof(RspDriverDatum).GetProperty("LicenseSourceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<LicenseSourceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            licenseSourceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDateTime = runtimeEntityType.AddProperty(
                "ModifiedDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(RspDriverDatum).GetProperty("ModifiedDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<ModifiedDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modifiedDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var nationalityId = runtimeEntityType.AddProperty(
                "NationalityId",
                typeof(int?),
                propertyInfo: typeof(RspDriverDatum).GetProperty("NationalityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<NationalityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            nationalityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var phoneNumber = runtimeEntityType.AddProperty(
                "PhoneNumber",
                typeof(string),
                propertyInfo: typeof(RspDriverDatum).GetProperty("PhoneNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<PhoneNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            phoneNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rspVehicleDataId = runtimeEntityType.AddProperty(
                "RspVehicleDataId",
                typeof(long?),
                propertyInfo: typeof(RspDriverDatum).GetProperty("RspVehicleDataId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<RspVehicleDataId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rspVehicleDataId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var trafficCode = runtimeEntityType.AddProperty(
                "TrafficCode",
                typeof(string),
                propertyInfo: typeof(RspDriverDatum).GetProperty("TrafficCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<TrafficCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            trafficCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { rspDriverDataId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__RspDrive__020D461DBB0D5C34");

            var index = runtimeEntityType.AddIndex(
                new[] { genderId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { licenseCategoryId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { licenseSourceId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { nationalityId });

            var index3 = runtimeEntityType.AddIndex(
                new[] { rspVehicleDataId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("GenderId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("GenderId") }),
                principalEntityType);

            var gender = declaringEntityType.AddNavigation("Gender",
                runtimeForeignKey,
                onDependent: true,
                typeof(GenderDim),
                propertyInfo: typeof(RspDriverDatum).GetProperty("Gender", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<Gender>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var rspDriverData = principalEntityType.AddNavigation("RspDriverData",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RspDriverDatum>),
                propertyInfo: typeof(GenderDim).GetProperty("RspDriverData", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GenderDim).GetField("<RspDriverData>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RspDriver__Gende__491C4D46");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("LicenseCategoryId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("LicenseCategoryId") }),
                principalEntityType);

            var licenseCategory = declaringEntityType.AddNavigation("LicenseCategory",
                runtimeForeignKey,
                onDependent: true,
                typeof(LicenseCategoryDim),
                propertyInfo: typeof(RspDriverDatum).GetProperty("LicenseCategory", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<LicenseCategory>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var rspDriverData = principalEntityType.AddNavigation("RspDriverData",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RspDriverDatum>),
                propertyInfo: typeof(LicenseCategoryDim).GetProperty("RspDriverData", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LicenseCategoryDim).GetField("<RspDriverData>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RspDriver__Licen__4B0495B8");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("LicenseSourceId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("LicensePlateListSourceId") }),
                principalEntityType);

            var licenseSource = declaringEntityType.AddNavigation("LicenseSource",
                runtimeForeignKey,
                onDependent: true,
                typeof(LicensePlateListSourceDim),
                propertyInfo: typeof(RspDriverDatum).GetProperty("LicenseSource", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<LicenseSource>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var rspDriverData = principalEntityType.AddNavigation("RspDriverData",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RspDriverDatum>),
                propertyInfo: typeof(LicensePlateListSourceDim).GetProperty("RspDriverData", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LicensePlateListSourceDim).GetField("<RspDriverData>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RspDriver__Licen__4A10717F");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("NationalityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("NationalityId") }),
                principalEntityType);

            var nationality = declaringEntityType.AddNavigation("Nationality",
                runtimeForeignKey,
                onDependent: true,
                typeof(NationalityDim),
                propertyInfo: typeof(RspDriverDatum).GetProperty("Nationality", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<Nationality>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var rspDriverData = principalEntityType.AddNavigation("RspDriverData",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RspDriverDatum>),
                propertyInfo: typeof(NationalityDim).GetProperty("RspDriverData", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(NationalityDim).GetField("<RspDriverData>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RspDriver__Natio__4BF8B9F1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey5(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RspVehicleDataId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("RspVehicleDataId") }),
                principalEntityType);

            var rspVehicleData = declaringEntityType.AddNavigation("RspVehicleData",
                runtimeForeignKey,
                onDependent: true,
                typeof(RspVehicleDatum),
                propertyInfo: typeof(RspDriverDatum).GetProperty("RspVehicleData", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspDriverDatum).GetField("<RspVehicleData>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var rspDriverData = principalEntityType.AddNavigation("RspDriverData",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RspDriverDatum>),
                propertyInfo: typeof(RspVehicleDatum).GetProperty("RspDriverData", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RspVehicleDatum).GetField("<RspDriverData>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RspDriver__RspVe__4CECDE2A");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "RspDriverData");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
