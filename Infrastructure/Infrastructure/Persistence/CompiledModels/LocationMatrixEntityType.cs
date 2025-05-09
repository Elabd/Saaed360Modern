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
    public partial class LocationMatrixEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.LocationMatrix",
                typeof(LocationMatrix),
                baseEntityType,
                propertyCount: 7,
                navigationCount: 5,
                foreignKeyCount: 5,
                unnamedIndexCount: 5,
                keyCount: 1);

            var locationMatrixId = runtimeEntityType.AddProperty(
                "LocationMatrixId",
                typeof(long),
                propertyInfo: typeof(LocationMatrix).GetProperty("LocationMatrixId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<LocationMatrixId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            locationMatrixId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var areaId = runtimeEntityType.AddProperty(
                "AreaId",
                typeof(long?),
                propertyInfo: typeof(LocationMatrix).GetProperty("AreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<AreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            areaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var cityId = runtimeEntityType.AddProperty(
                "CityId",
                typeof(long?),
                propertyInfo: typeof(LocationMatrix).GetProperty("CityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<CityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            cityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emiratesId = runtimeEntityType.AddProperty(
                "EmiratesId",
                typeof(long?),
                propertyInfo: typeof(LocationMatrix).GetProperty("EmiratesId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<EmiratesId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            emiratesId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isActive = runtimeEntityType.AddProperty(
                "IsActive",
                typeof(bool?),
                propertyInfo: typeof(LocationMatrix).GetProperty("IsActive", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<IsActive>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isActive.AddAnnotation("Relational:DefaultValue", true);
            isActive.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sectorId = runtimeEntityType.AddProperty(
                "SectorId",
                typeof(long?),
                propertyInfo: typeof(LocationMatrix).GetProperty("SectorId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<SectorId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            sectorId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var streetId = runtimeEntityType.AddProperty(
                "StreetId",
                typeof(long?),
                propertyInfo: typeof(LocationMatrix).GetProperty("StreetId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<StreetId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            streetId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { locationMatrixId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__Location__41FC1017717B4791");

            var index = runtimeEntityType.AddIndex(
                new[] { areaId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { cityId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { emiratesId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { sectorId });

            var index3 = runtimeEntityType.AddIndex(
                new[] { streetId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AreaId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AreaId") }),
                principalEntityType);

            var area = declaringEntityType.AddNavigation("Area",
                runtimeForeignKey,
                onDependent: true,
                typeof(Area),
                propertyInfo: typeof(LocationMatrix).GetProperty("Area", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<Area>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var locationMatrixAreas = principalEntityType.AddNavigation("LocationMatrixAreas",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<LocationMatrix>),
                propertyInfo: typeof(Area).GetProperty("LocationMatrixAreas", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Area).GetField("<LocationMatrixAreas>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "fk_LocationMatrix_Area_Area");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("CityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AreaId") }),
                principalEntityType);

            var city = declaringEntityType.AddNavigation("City",
                runtimeForeignKey,
                onDependent: true,
                typeof(Area),
                propertyInfo: typeof(LocationMatrix).GetProperty("City", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<City>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var locationMatrixCities = principalEntityType.AddNavigation("LocationMatrixCities",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<LocationMatrix>),
                propertyInfo: typeof(Area).GetProperty("LocationMatrixCities", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Area).GetField("<LocationMatrixCities>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "fk_LocationMatrix_Area_City");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("EmiratesId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AreaId") }),
                principalEntityType);

            var emirates = declaringEntityType.AddNavigation("Emirates",
                runtimeForeignKey,
                onDependent: true,
                typeof(Area),
                propertyInfo: typeof(LocationMatrix).GetProperty("Emirates", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<Emirates>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var locationMatrixEmirates = principalEntityType.AddNavigation("LocationMatrixEmirates",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<LocationMatrix>),
                propertyInfo: typeof(Area).GetProperty("LocationMatrixEmirates", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Area).GetField("<LocationMatrixEmirates>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "fk_LocationMatrix_Area_Emirates");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("SectorId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AreaId") }),
                principalEntityType);

            var sector = declaringEntityType.AddNavigation("Sector",
                runtimeForeignKey,
                onDependent: true,
                typeof(Area),
                propertyInfo: typeof(LocationMatrix).GetProperty("Sector", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<Sector>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var locationMatrixSectors = principalEntityType.AddNavigation("LocationMatrixSectors",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<LocationMatrix>),
                propertyInfo: typeof(Area).GetProperty("LocationMatrixSectors", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Area).GetField("<LocationMatrixSectors>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "fk_LocationMatrix_Area_Sector");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey5(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("StreetId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AreaId") }),
                principalEntityType);

            var street = declaringEntityType.AddNavigation("Street",
                runtimeForeignKey,
                onDependent: true,
                typeof(Area),
                propertyInfo: typeof(LocationMatrix).GetProperty("Street", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationMatrix).GetField("<Street>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var locationMatrixStreets = principalEntityType.AddNavigation("LocationMatrixStreets",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<LocationMatrix>),
                propertyInfo: typeof(Area).GetProperty("LocationMatrixStreets", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Area).GetField("<LocationMatrixStreets>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "fk_LocationMatrix_Area_Street");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "LocationMatrix");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
