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
    public partial class MobileUserEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.MobileUser",
                typeof(MobileUser),
                baseEntityType,
                propertyCount: 29,
                navigationCount: 10,
                foreignKeyCount: 8,
                unnamedIndexCount: 8,
                keyCount: 1);

            var mobileUserId = runtimeEntityType.AddProperty(
                "MobileUserId",
                typeof(long),
                propertyInfo: typeof(MobileUser).GetProperty("MobileUserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<MobileUserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            mobileUserId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var areaId = runtimeEntityType.AddProperty(
                "AreaId",
                typeof(long?),
                propertyInfo: typeof(MobileUser).GetProperty("AreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<AreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            areaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var cityId = runtimeEntityType.AddProperty(
                "CityId",
                typeof(long?),
                propertyInfo: typeof(MobileUser).GetProperty("CityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<CityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            cityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var communicationChannelId = runtimeEntityType.AddProperty(
                "CommunicationChannelId",
                typeof(int?),
                propertyInfo: typeof(MobileUser).GetProperty("CommunicationChannelId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<CommunicationChannelId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            communicationChannelId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime),
                propertyInfo: typeof(MobileUser).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            creationDate.AddAnnotation("Relational:ColumnType", "datetime");
            creationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var dateOfBirth = runtimeEntityType.AddProperty(
                "DateOfBirth",
                typeof(DateTime?),
                propertyInfo: typeof(MobileUser).GetProperty("DateOfBirth", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<DateOfBirth>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            dateOfBirth.AddAnnotation("Relational:ColumnType", "datetime");
            dateOfBirth.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var deletionDate = runtimeEntityType.AddProperty(
                "DeletionDate",
                typeof(DateTime?),
                propertyInfo: typeof(MobileUser).GetProperty("DeletionDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<DeletionDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            deletionDate.AddAnnotation("Relational:ColumnType", "datetime");
            deletionDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var detailedAddress = runtimeEntityType.AddProperty(
                "DetailedAddress",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("DetailedAddress", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<DetailedAddress>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            detailedAddress.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var email = runtimeEntityType.AddProperty(
                "Email",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("Email", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<Email>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 500);
            email.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emirateId = runtimeEntityType.AddProperty(
                "EmirateId",
                typeof(long?),
                propertyInfo: typeof(MobileUser).GetProperty("EmirateId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<EmirateId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            emirateId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var enforcePasswordChange = runtimeEntityType.AddProperty(
                "EnforcePasswordChange",
                typeof(bool),
                propertyInfo: typeof(MobileUser).GetProperty("EnforcePasswordChange", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<EnforcePasswordChange>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: true);
            enforcePasswordChange.AddAnnotation("Relational:DefaultValue", true);
            enforcePasswordChange.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var genderId = runtimeEntityType.AddProperty(
                "GenderId",
                typeof(int?),
                propertyInfo: typeof(MobileUser).GetProperty("GenderId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<GenderId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            genderId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var historicalTrackingHashedPassword = runtimeEntityType.AddProperty(
                "HistoricalTrackingHashedPassword",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("HistoricalTrackingHashedPassword", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<HistoricalTrackingHashedPassword>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 150,
                unicode: false);
            historicalTrackingHashedPassword.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var identityEmiratesId = runtimeEntityType.AddProperty(
                "IdentityEmiratesId",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("IdentityEmiratesId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<IdentityEmiratesId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            identityEmiratesId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool),
                propertyInfo: typeof(MobileUser).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var languageId = runtimeEntityType.AddProperty(
                "LanguageId",
                typeof(int?),
                propertyInfo: typeof(MobileUser).GetProperty("LanguageId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<LanguageId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            languageId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var mobileNumber = runtimeEntityType.AddProperty(
                "MobileNumber",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("MobileNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<MobileNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            mobileNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var mobileVerified = runtimeEntityType.AddProperty(
                "MobileVerified",
                typeof(bool),
                propertyInfo: typeof(MobileUser).GetProperty("MobileVerified", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<MobileVerified>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            mobileVerified.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var nationality = runtimeEntityType.AddProperty(
                "Nationality",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("Nationality", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<Nationality>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            nationality.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var nationalityId = runtimeEntityType.AddProperty(
                "NationalityId",
                typeof(int?),
                propertyInfo: typeof(MobileUser).GetProperty("NationalityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<NationalityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            nationalityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var password = runtimeEntityType.AddProperty(
                "Password",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("Password", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<Password>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            password.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var passwordChangeAttemptsCount = runtimeEntityType.AddProperty(
                "PasswordChangeAttemptsCount",
                typeof(int),
                propertyInfo: typeof(MobileUser).GetProperty("PasswordChangeAttemptsCount", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<PasswordChangeAttemptsCount>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            passwordChangeAttemptsCount.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var passwordChangeDate = runtimeEntityType.AddProperty(
                "PasswordChangeDate",
                typeof(DateTime),
                propertyInfo: typeof(MobileUser).GetProperty("PasswordChangeDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<PasswordChangeDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            passwordChangeDate.AddAnnotation("Relational:ColumnType", "datetime");
            passwordChangeDate.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            passwordChangeDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var passwordExpirationDate = runtimeEntityType.AddProperty(
                "PasswordExpirationDate",
                typeof(DateTime),
                propertyInfo: typeof(MobileUser).GetProperty("PasswordExpirationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<PasswordExpirationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            passwordExpirationDate.AddAnnotation("Relational:ColumnType", "datetime");
            passwordExpirationDate.AddAnnotation("Relational:DefaultValueSql", "(dateadd(day,(90),getdate()))");
            passwordExpirationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var registerationRequestId = runtimeEntityType.AddProperty(
                "RegisterationRequestId",
                typeof(long?),
                propertyInfo: typeof(MobileUser).GetProperty("RegisterationRequestId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<RegisterationRequestId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            registerationRequestId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var salt = runtimeEntityType.AddProperty(
                "Salt",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("Salt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<Salt>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            salt.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var tcn = runtimeEntityType.AddProperty(
                "Tcn",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("Tcn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<Tcn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            tcn.AddAnnotation("Relational:ColumnName", "TCN");
            tcn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var uaepassUuid = runtimeEntityType.AddProperty(
                "UaepassUuid",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("UaepassUuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<UaepassUuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 500);
            uaepassUuid.AddAnnotation("Relational:ColumnName", "UAEPassUUID");
            uaepassUuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var username = runtimeEntityType.AddProperty(
                "Username",
                typeof(string),
                propertyInfo: typeof(MobileUser).GetProperty("Username", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<Username>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 500);
            username.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { mobileUserId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { areaId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { cityId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { communicationChannelId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { emirateId });

            var index3 = runtimeEntityType.AddIndex(
                new[] { genderId });

            var index4 = runtimeEntityType.AddIndex(
                new[] { languageId });

            var index5 = runtimeEntityType.AddIndex(
                new[] { nationalityId });

            var index6 = runtimeEntityType.AddIndex(
                new[] { registerationRequestId });

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
                propertyInfo: typeof(MobileUser).GetProperty("Area", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<Area>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var mobileUsers = principalEntityType.AddNavigation("MobileUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<MobileUser>),
                propertyInfo: typeof(Area).GetProperty("MobileUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Area).GetField("<MobileUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MobileUser_Area");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("CityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("CityId") }),
                principalEntityType);

            var city = declaringEntityType.AddNavigation("City",
                runtimeForeignKey,
                onDependent: true,
                typeof(CityDim),
                propertyInfo: typeof(MobileUser).GetProperty("City", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<City>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var mobileUsers = principalEntityType.AddNavigation("MobileUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<MobileUser>),
                propertyInfo: typeof(CityDim).GetProperty("MobileUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CityDim).GetField("<MobileUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MobileUser_City");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("CommunicationChannelId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("CommunicationMethodId") }),
                principalEntityType);

            var communicationChannel = declaringEntityType.AddNavigation("CommunicationChannel",
                runtimeForeignKey,
                onDependent: true,
                typeof(CommunicationMethodsDim),
                propertyInfo: typeof(MobileUser).GetProperty("CommunicationChannel", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<CommunicationChannel>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var mobileUsers = principalEntityType.AddNavigation("MobileUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<MobileUser>),
                propertyInfo: typeof(CommunicationMethodsDim).GetProperty("MobileUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CommunicationMethodsDim).GetField("<MobileUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MobileUser_CommunicationMethod");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("EmirateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("EmirateId") }),
                principalEntityType);

            var emirate = declaringEntityType.AddNavigation("Emirate",
                runtimeForeignKey,
                onDependent: true,
                typeof(EmirateDim),
                propertyInfo: typeof(MobileUser).GetProperty("Emirate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<Emirate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var mobileUsers = principalEntityType.AddNavigation("MobileUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<MobileUser>),
                propertyInfo: typeof(EmirateDim).GetProperty("MobileUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EmirateDim).GetField("<MobileUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MobileUser_Emirate");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey5(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("GenderId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("GenderId") }),
                principalEntityType);

            var gender = declaringEntityType.AddNavigation("Gender",
                runtimeForeignKey,
                onDependent: true,
                typeof(GenderDim),
                propertyInfo: typeof(MobileUser).GetProperty("Gender", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<Gender>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var mobileUsers = principalEntityType.AddNavigation("MobileUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<MobileUser>),
                propertyInfo: typeof(GenderDim).GetProperty("MobileUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GenderDim).GetField("<MobileUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MobileUser_Gender");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey6(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("LanguageId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("LanguageId") }),
                principalEntityType);

            var language = declaringEntityType.AddNavigation("Language",
                runtimeForeignKey,
                onDependent: true,
                typeof(LanguageDim),
                propertyInfo: typeof(MobileUser).GetProperty("Language", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<Language>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var mobileUsers = principalEntityType.AddNavigation("MobileUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<MobileUser>),
                propertyInfo: typeof(LanguageDim).GetProperty("MobileUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LanguageDim).GetField("<MobileUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MobileUser_Language");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey7(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("NationalityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("NationalityId") }),
                principalEntityType);

            var nationalityNavigation = declaringEntityType.AddNavigation("NationalityNavigation",
                runtimeForeignKey,
                onDependent: true,
                typeof(NationalityDim),
                propertyInfo: typeof(MobileUser).GetProperty("NationalityNavigation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<NationalityNavigation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var mobileUsers = principalEntityType.AddNavigation("MobileUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<MobileUser>),
                propertyInfo: typeof(NationalityDim).GetProperty("MobileUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(NationalityDim).GetField("<MobileUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MobileUser_Nationality");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey8(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RegisterationRequestId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("RequestUserId") }),
                principalEntityType);

            var registerationRequest = declaringEntityType.AddNavigation("RegisterationRequest",
                runtimeForeignKey,
                onDependent: true,
                typeof(MobileRegistrationUserRequest),
                propertyInfo: typeof(MobileUser).GetProperty("RegisterationRequest", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileUser).GetField("<RegisterationRequest>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var mobileUsers = principalEntityType.AddNavigation("MobileUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<MobileUser>),
                propertyInfo: typeof(MobileRegistrationUserRequest).GetProperty("MobileUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileRegistrationUserRequest).GetField("<MobileUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MobileUser_MobileRegistrationUserRequest");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "MobileUser");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
