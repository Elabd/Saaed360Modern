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
    public partial class SmartDispatchingAreaConfigurationEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.SmartDispatchingAreaConfiguration",
                typeof(SmartDispatchingAreaConfiguration),
                baseEntityType,
                propertyCount: 6,
                navigationCount: 1,
                foreignKeyCount: 1,
                namedIndexCount: 1,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(SmartDispatchingAreaConfiguration).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SmartDispatchingAreaConfiguration).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var areaId = runtimeEntityType.AddProperty(
                "AreaId",
                typeof(long),
                propertyInfo: typeof(SmartDispatchingAreaConfiguration).GetProperty("AreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SmartDispatchingAreaConfiguration).GetField("<AreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            areaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var desertAreaTime = runtimeEntityType.AddProperty(
                "DesertAreaTime",
                typeof(int?),
                propertyInfo: typeof(SmartDispatchingAreaConfiguration).GetProperty("DesertAreaTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SmartDispatchingAreaConfiguration).GetField("<DesertAreaTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            desertAreaTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isEnabled = runtimeEntityType.AddProperty(
                "IsEnabled",
                typeof(bool),
                propertyInfo: typeof(SmartDispatchingAreaConfiguration).GetProperty("IsEnabled", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SmartDispatchingAreaConfiguration).GetField("<IsEnabled>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isEnabled.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var ruralAreaTime = runtimeEntityType.AddProperty(
                "RuralAreaTime",
                typeof(int?),
                propertyInfo: typeof(SmartDispatchingAreaConfiguration).GetProperty("RuralAreaTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SmartDispatchingAreaConfiguration).GetField("<RuralAreaTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            ruralAreaTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var urbanAreaTime = runtimeEntityType.AddProperty(
                "UrbanAreaTime",
                typeof(int?),
                propertyInfo: typeof(SmartDispatchingAreaConfiguration).GetProperty("UrbanAreaTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SmartDispatchingAreaConfiguration).GetField("<UrbanAreaTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            urbanAreaTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__SmartDis__3214EC07C7EA08E9");

            var uQ__SmartDis__70B820493C656800 = runtimeEntityType.AddIndex(
                new[] { areaId },
                name: "UQ__SmartDis__70B820493C656800",
                unique: true);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AreaId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AreaId") }),
                principalEntityType,
                unique: true,
                required: true);

            var area = declaringEntityType.AddNavigation("Area",
                runtimeForeignKey,
                onDependent: true,
                typeof(Area),
                propertyInfo: typeof(SmartDispatchingAreaConfiguration).GetProperty("Area", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SmartDispatchingAreaConfiguration).GetField("<Area>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var smartDispatchingAreaConfiguration = principalEntityType.AddNavigation("SmartDispatchingAreaConfiguration",
                runtimeForeignKey,
                onDependent: false,
                typeof(SmartDispatchingAreaConfiguration),
                propertyInfo: typeof(Area).GetProperty("SmartDispatchingAreaConfiguration", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Area).GetField("<SmartDispatchingAreaConfiguration>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_AreaConfiguration_Area");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "SmartDispatchingAreaConfiguration");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
