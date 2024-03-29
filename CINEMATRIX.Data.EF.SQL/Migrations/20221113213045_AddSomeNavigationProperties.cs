﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CINEMATRIX.Data.EF.SQL.Migrations
{
    public partial class AddSomeNavigationProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Profile_ProfileId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 420L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 433L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 437L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 438L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 439L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 440L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 444L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 445L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 446L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 447L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 448L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 449L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 450L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 451L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 452L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 453L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 454L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 455L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 456L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 457L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 458L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 459L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 462L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 463L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 464L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 465L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 466L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 467L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 468L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 469L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 470L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 471L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 476L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 477L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 478L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 479L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 480L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 420L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 433L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 434L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 435L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 436L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 437L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 438L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 439L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 440L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 444L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 445L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 446L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 447L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 448L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 449L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 450L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 451L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 452L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 453L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 454L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 455L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 456L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 457L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 458L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 459L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 460L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 461L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 462L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 463L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 464L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 465L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 466L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 467L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 468L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 469L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 470L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 471L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 473L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 474L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 475L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 476L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 477L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 478L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 479L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 480L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 481L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 482L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 483L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 484L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 485L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 486L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 487L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 488L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 489L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 490L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 491L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 492L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 493L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 494L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 495L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 496L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 497L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 498L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 499L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 500L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 501L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 502L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 503L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 504L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 505L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 506L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 507L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 508L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 509L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 510L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 511L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 512L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 513L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 514L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 515L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 516L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 517L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 518L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 519L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 520L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 521L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 522L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 523L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 524L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 525L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 526L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 527L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 528L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 529L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 530L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 531L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 532L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 533L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 534L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 535L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 536L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 537L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 538L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 539L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 540L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 541L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 542L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 543L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 544L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 545L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 546L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 547L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 548L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 549L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 550L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 551L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 552L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 553L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 554L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 555L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 556L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 557L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 558L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 559L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 560L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 561L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 562L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 563L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 564L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 565L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 566L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 567L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 568L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 569L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 570L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 571L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 572L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 573L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 574L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 575L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 576L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 577L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 578L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 579L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 580L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 581L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 582L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 583L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 584L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 585L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 586L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 587L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 588L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 589L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 590L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 591L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 592L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 593L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 594L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 595L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 596L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 597L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 598L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 599L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 600L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 601L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 602L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 603L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 604L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 605L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 606L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 607L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 608L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 609L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 610L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 611L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 612L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 613L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 614L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 615L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 616L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 617L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 618L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 619L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 620L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 621L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 622L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 623L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 624L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 625L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 626L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 627L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 628L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 629L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 630L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 631L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 632L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 633L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 634L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 635L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 636L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 637L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 638L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 639L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 640L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 641L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 642L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 643L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 644L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 645L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 646L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 647L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 648L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 649L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 650L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 651L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 652L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 653L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 654L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 655L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 656L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 657L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 658L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 659L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 660L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 661L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 662L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 663L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 664L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 665L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 666L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 667L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 668L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 669L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 670L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 671L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 672L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 673L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 674L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 675L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 676L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 677L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 678L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 679L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 680L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 681L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 682L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 683L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 684L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 685L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 686L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 687L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 688L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 689L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 690L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 691L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 692L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 693L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 694L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 695L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 696L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 697L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 698L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 699L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 700L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 701L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 702L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 703L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 704L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 705L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 706L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 707L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 708L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 709L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 710L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 711L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 712L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 713L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 714L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 715L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 716L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 717L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 718L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 719L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 720L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 721L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 722L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 723L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 724L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 725L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 726L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 727L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 728L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 729L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 730L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 731L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 732L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 733L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 734L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 735L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 736L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 737L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 738L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 739L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 740L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 741L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 742L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 743L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 744L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 745L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 746L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 747L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 748L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 749L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 750L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 751L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 752L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 753L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 754L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 755L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 756L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 757L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 758L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 759L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 760L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 761L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 762L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 763L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 764L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 765L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 766L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 767L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 768L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 769L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 770L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 771L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 772L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 773L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 774L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 775L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 776L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 777L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 778L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 779L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 780L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 781L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 782L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 783L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 784L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 785L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 786L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 787L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 788L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 789L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 790L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 791L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 792L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 793L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 794L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 795L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 796L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 797L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 798L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 799L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 800L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 801L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 802L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 803L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 804L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 805L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 806L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 807L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 808L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 809L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 810L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 811L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 812L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 813L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 814L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 815L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 816L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 817L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 818L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 819L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 820L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 821L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 822L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 823L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 824L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 825L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 826L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 827L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 828L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 829L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 830L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 831L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 832L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 833L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 834L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 835L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 836L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 837L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 838L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 839L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 840L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 841L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 842L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 843L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 844L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 845L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 846L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 847L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 848L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 849L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 850L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 851L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 852L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 853L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 854L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 855L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 856L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 857L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 858L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 859L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 860L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 861L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 862L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 863L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 864L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 865L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 866L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 867L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 868L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 869L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 870L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 871L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 872L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 873L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 874L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 875L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 876L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 877L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 878L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 879L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 880L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 881L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 882L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 883L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 884L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 885L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 886L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 887L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 888L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 889L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 890L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 891L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 892L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 893L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 894L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 895L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 896L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 897L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 898L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 899L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 900L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 901L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 902L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 903L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 904L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 905L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 906L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 907L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 908L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 909L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 910L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 911L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 912L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 913L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 914L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 915L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 916L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 917L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 918L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 919L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 920L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 921L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 922L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 923L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 924L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 925L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 926L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 927L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 928L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 929L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 930L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 931L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 932L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 933L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 934L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 935L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 936L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 937L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 938L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 939L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 940L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 941L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 942L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 943L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 944L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 945L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 946L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 947L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 948L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 949L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 950L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 951L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 952L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 953L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 954L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 955L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 956L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 957L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 958L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 959L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 960L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 961L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 962L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 963L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 964L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 965L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 966L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 967L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 968L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 969L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 970L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 971L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 972L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 973L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 974L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 975L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 976L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 977L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 978L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 979L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 980L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 981L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 982L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 983L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 984L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 985L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 986L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 987L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 988L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 989L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 990L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 991L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 992L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 993L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 994L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 995L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 996L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 997L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 998L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 999L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1000L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1001L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1002L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1003L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1004L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1005L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1006L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1007L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1008L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1009L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1010L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1011L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1012L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1013L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1014L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1015L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1016L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1017L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1018L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1019L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1020L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1021L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1022L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1023L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1024L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1025L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1026L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1027L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1028L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1029L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1030L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1031L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1032L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1033L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1034L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1035L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1036L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1037L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1038L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1039L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1040L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1041L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1042L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1043L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1044L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1045L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1046L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1047L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1048L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1049L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1050L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1051L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1052L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1053L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1054L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1055L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1056L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1057L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1058L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1059L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1060L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1061L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1062L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1063L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1064L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1065L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1066L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1067L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1068L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1069L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1070L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1071L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1072L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1073L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1074L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1075L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1076L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1077L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1078L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1079L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1080L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1081L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1082L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1083L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1084L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1085L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1086L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1087L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1088L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1089L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1090L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1091L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1092L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1093L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1094L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1095L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1096L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1097L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1098L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1099L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1100L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1101L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1102L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1103L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1104L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1105L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1106L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1107L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1108L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1109L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1110L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1111L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1112L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1113L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1114L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1115L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1116L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1117L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1118L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1119L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1120L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 434L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 435L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 436L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 460L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 461L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 473L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 474L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 475L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "SeatTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "SeatTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "SeatTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.AlterColumn<long>(
                name: "ProfileId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProfileId",
                table: "Tickets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CinemaId",
                table: "Halls",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProfileId",
                table: "Tickets",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Halls_CinemaId",
                table: "Halls",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Halls_Cinemas_CinemaId",
                table: "Halls",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Profile_ProfileId",
                table: "Tickets",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Profile_ProfileId",
                table: "Users",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Halls_Cinemas_CinemaId",
                table: "Halls");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Profile_ProfileId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Profile_ProfileId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ProfileId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Halls_CinemaId",
                table: "Halls");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Halls");

            migrationBuilder.AlterColumn<long>(
                name: "ProfileId",
                table: "Users",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Address", "ContactNumber", "Email", "Name" },
                values: new object[] { 1L, "Novopolotsk Pushkina street", "+37529281133", "cinematrix@gmail.com", "Cinematrix" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Description", "Name", "Price", "UrlPicture" },
                values: new object[,]
                {
                    { 1L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Small Plain Popcorn", 3m, "https://i.pinimg.com/564x/27/54/4b/27544b30e1f053ef55aefc2758184445.jpg" },
                    { 2L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Medium Plain Popcorn", 4.5m, "https://i.pinimg.com/564x/fc/cf/dc/fccfdcbe5355ba1b2662d92c305b6402.jpg" },
                    { 3L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Large Plain Popcorn", 6m, "https://i.pinimg.com/564x/ad/0b/be/ad0bbe7809102011d85f2e9bc87b7b90.jpg" },
                    { 4L, "A pretzel is a handheld yeast bread that's usually shaped into a twisted knot.", "Pretzel Bites", 4m, "https://i.pinimg.com/564x/15/ed/22/15ed22eb6702c520995a7f146c088505.jpg" },
                    { 5L, "A kind of fries characterized by their spring-like shape, being cut from whole potatoes using a specialized spiral slicer.", "Curcly Fries", 4m, "https://i.pinimg.com/564x/67/63/26/6763268fae390dfae890e73eeb96b51c.jpg" },
                    { 6L, "French fries are long, thin pieces of potato fried in oil or fat. The French fries were thin and crispy. To cook the French fries, put them into a deep pan of oil.", "Fries", 3m, "https://i.pinimg.com/564x/7b/a7/f6/7ba7f65ae13d844bd26289b7ee8b8d8f.jpg" },
                    { 7L, "A deep-fried strip of chicken without bones or skin. A flap of chicken meat found on, and easily detached from, the breast.", "Chicken Tenders", 5m, "https://i.pinimg.com/564x/f1/e6/1c/f1e61c6808735b1b69a4b28d83417382.jpg" },
                    { 8L, "Mozerella sticks are typically eaten with Marinara. However, ranch, Thai sweet chili, cocktail sauce, BBQ, hot sauce, regular mayonnaise, garlic aioli, buffalo sauce, ketchup, tzatziki, donair, alfredo, salsa, and hollandaise are all good sauces to try.", "Mozzarella Sticks", 5m, "https://i.pinimg.com/564x/b0/46/31/b046315f129b2b1e002b5c8183c893c7.jpg" },
                    { 9L, "A hot dog is a food consisting of a grilled or steamed sausage served in the slit of a partially sliced bun. The term hot dog can also refer to the sausage itself.", "Hot Dog", 3m, "https://i.pinimg.com/564x/6d/7c/9e/6d7c9e6e15e8206339eaa91c3b810ce7.jpg" },
                    { 10L, "A sauce made of butter, water or broth, and seasonings, thickened with flour, and used also as a basis for the making of other sauces (such as caper sauce or shrimp sauce) by the addition of special ingredients.", "Butter Topping", 4m, "https://i.pinimg.com/564x/78/2d/c1/782dc1b23a49df94690528e9f355c477.jpg" },
                    { 11L, "Melted cheese garnished with sliced chile peppers that is traditionally served with tortilla chips.", "Nacho Cheese", 5m, "https://i.pinimg.com/564x/97/c4/ac/97c4ac886aa8731e8ccf3e689be6a226.jpg" },
                    { 12L, "A tortilla chip or nacho chips is a snack food made from corn tortillas, which are cut into wedges and then fried.", "Nachos", 3m, "https://i.pinimg.com/564x/d5/fa/fd/d5fafd4b3e1812c233fcff9412080601.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Description", "Name", "Projector", "Screen", "ScreenResolution", "SoundSystem" },
                values: new object[,]
                {
                    { 5L, "Standard seats. For two Sofa Love.", "ATMOS", "Sony", "13,3 x 5,7", "4K", "Dolby 7,1" },
                    { 4L, "Standard seats. For two Sofa Love.", "BIG HALL", "Sony", "13,3 x 5,7", "4K", "Dolby 7,1" },
                    { 1L, "Comfortable recliner chairs with adjustable back tilt, leg support and individual tables for each chair.", "LUX", "Sony", "8,7 x 3,9", "4K", "Dolby 7,1" },
                    { 2L, "Soft sofas for two. The atmosphere of privacy and comfort in individual boxes.", "SWEET BOX", "Sony", "8,7 х 3,9", "4K", "Dolby 7,1" },
                    { 3L, "Standard seats. For two Sofa Love.", "SMALL HALL", "Sony", "8,7 х 3,9", "4K", "Dolby 7,1" }
                });

            migrationBuilder.InsertData(
                table: "Posters",
                columns: new[] { "Id", "IsRentMovie", "MovieId" },
                values: new object[,]
                {
                    { 12L, true, 760741L },
                    { 20L, true, 999205L },
                    { 19L, true, 985939L },
                    { 18L, true, 961484L },
                    { 17L, true, 921360L },
                    { 16L, true, 916605L },
                    { 15L, true, 882598L },
                    { 14L, true, 877957L },
                    { 13L, true, 762504L },
                    { 11L, true, 760161L },
                    { 6L, true, 634649L },
                    { 9L, true, 744276L },
                    { 10L, true, 756999L },
                    { 2L, true, 526896L },
                    { 3L, true, 539681L },
                    { 4L, true, 576925L },
                    { 1L, true, 19995L },
                    { 7L, true, 639933L },
                    { 8L, true, 718930L },
                    { 5L, true, 610150L }
                });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "DateOfBirth", "Name", "PhoneNumber", "SecondName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2002, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Admin", "+375291111111", "Admin" },
                    { 2L, new DateTime(2001, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "Staff", "+375291111112", "Staff" },
                    { 3L, new DateTime(2000, 11, 11, 0, 0, 0, 0, DateTimeKind.Local), "User", "+375291111113", "User" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1L, "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2L, "Staff" },
                    { 3L, "User" }
                });

            migrationBuilder.InsertData(
                table: "SeatTypes",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 2L, "Lux", 6m },
                    { 1L, "Standart", 4m },
                    { 3L, "Romantic", 8m }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 480L, 5L, 10, 11, 3L },
                    { 218L, 4L, 14, 5, 1L },
                    { 219L, 4L, 15, 5, 1L },
                    { 220L, 4L, 1, 6, 1L },
                    { 221L, 4L, 2, 6, 1L },
                    { 222L, 4L, 3, 6, 1L },
                    { 223L, 4L, 4, 6, 1L },
                    { 224L, 4L, 5, 6, 1L },
                    { 225L, 4L, 6, 6, 1L },
                    { 226L, 4L, 7, 6, 1L },
                    { 227L, 4L, 8, 6, 1L },
                    { 228L, 4L, 9, 6, 1L },
                    { 229L, 4L, 10, 6, 1L },
                    { 217L, 4L, 13, 5, 1L },
                    { 230L, 4L, 11, 6, 1L },
                    { 232L, 4L, 13, 6, 1L },
                    { 233L, 4L, 14, 6, 1L },
                    { 234L, 4L, 15, 6, 1L },
                    { 235L, 4L, 1, 7, 1L },
                    { 236L, 4L, 2, 7, 1L },
                    { 237L, 4L, 3, 7, 1L },
                    { 238L, 4L, 4, 7, 1L },
                    { 239L, 4L, 5, 7, 1L },
                    { 240L, 4L, 6, 7, 1L },
                    { 241L, 4L, 7, 7, 1L },
                    { 242L, 4L, 8, 7, 1L },
                    { 243L, 4L, 9, 7, 1L },
                    { 231L, 4L, 12, 6, 1L },
                    { 244L, 4L, 10, 7, 1L },
                    { 216L, 4L, 12, 5, 1L },
                    { 214L, 4L, 10, 5, 1L },
                    { 188L, 4L, 14, 3, 1L },
                    { 189L, 4L, 15, 3, 1L },
                    { 190L, 4L, 1, 4, 1L },
                    { 191L, 4L, 2, 4, 1L },
                    { 192L, 4L, 3, 4, 1L },
                    { 193L, 4L, 4, 4, 1L },
                    { 194L, 4L, 5, 4, 1L },
                    { 195L, 4L, 6, 4, 1L },
                    { 196L, 4L, 7, 4, 1L },
                    { 197L, 4L, 8, 4, 1L },
                    { 198L, 4L, 9, 4, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 199L, 4L, 10, 4, 1L },
                    { 215L, 4L, 11, 5, 1L },
                    { 200L, 4L, 11, 4, 1L },
                    { 202L, 4L, 13, 4, 1L },
                    { 203L, 4L, 14, 4, 1L },
                    { 204L, 4L, 15, 4, 1L },
                    { 205L, 4L, 1, 5, 1L },
                    { 206L, 4L, 2, 5, 1L },
                    { 207L, 4L, 3, 5, 1L },
                    { 208L, 4L, 4, 5, 1L },
                    { 209L, 4L, 5, 5, 1L },
                    { 210L, 4L, 6, 5, 1L },
                    { 211L, 4L, 7, 5, 1L },
                    { 212L, 4L, 8, 5, 1L },
                    { 213L, 4L, 9, 5, 1L },
                    { 201L, 4L, 12, 4, 1L },
                    { 187L, 4L, 13, 3, 1L },
                    { 245L, 4L, 11, 7, 1L },
                    { 247L, 4L, 13, 7, 1L },
                    { 320L, 5L, 14, 1, 1L },
                    { 321L, 5L, 15, 1, 1L },
                    { 322L, 5L, 16, 1, 1L },
                    { 323L, 5L, 1, 2, 1L },
                    { 324L, 5L, 2, 2, 1L },
                    { 325L, 5L, 3, 2, 1L },
                    { 326L, 5L, 4, 2, 1L },
                    { 327L, 5L, 5, 2, 1L },
                    { 328L, 5L, 6, 2, 1L },
                    { 329L, 5L, 7, 2, 1L },
                    { 330L, 5L, 8, 2, 1L },
                    { 331L, 5L, 9, 2, 1L },
                    { 319L, 5L, 13, 1, 1L },
                    { 332L, 5L, 10, 2, 1L },
                    { 334L, 5L, 12, 2, 1L },
                    { 335L, 5L, 13, 2, 1L },
                    { 336L, 5L, 14, 2, 1L },
                    { 337L, 5L, 15, 2, 1L },
                    { 338L, 5L, 16, 2, 1L },
                    { 339L, 5L, 1, 3, 1L },
                    { 340L, 5L, 2, 3, 1L },
                    { 341L, 5L, 3, 3, 1L },
                    { 342L, 5L, 4, 3, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 343L, 5L, 5, 3, 1L },
                    { 344L, 5L, 6, 3, 1L },
                    { 345L, 5L, 7, 3, 1L },
                    { 333L, 5L, 11, 2, 1L },
                    { 246L, 4L, 12, 7, 1L },
                    { 318L, 5L, 12, 1, 1L },
                    { 316L, 5L, 10, 1, 1L },
                    { 248L, 4L, 14, 7, 1L },
                    { 249L, 4L, 15, 7, 1L },
                    { 250L, 4L, 1, 8, 1L },
                    { 251L, 4L, 2, 8, 1L },
                    { 252L, 4L, 3, 8, 1L },
                    { 253L, 4L, 4, 8, 1L },
                    { 254L, 4L, 5, 8, 1L },
                    { 255L, 4L, 6, 8, 1L },
                    { 256L, 4L, 7, 8, 1L },
                    { 257L, 4L, 8, 8, 1L },
                    { 258L, 4L, 9, 8, 1L },
                    { 259L, 4L, 10, 8, 1L },
                    { 317L, 5L, 11, 1, 1L },
                    { 260L, 4L, 11, 8, 1L },
                    { 262L, 4L, 13, 8, 1L },
                    { 263L, 4L, 14, 8, 1L },
                    { 264L, 4L, 15, 8, 1L },
                    { 307L, 5L, 1, 1, 1L },
                    { 308L, 5L, 2, 1, 1L },
                    { 309L, 5L, 3, 1, 1L },
                    { 310L, 5L, 4, 1, 1L },
                    { 311L, 5L, 5, 1, 1L },
                    { 312L, 5L, 6, 1, 1L },
                    { 313L, 5L, 7, 1, 1L },
                    { 314L, 5L, 8, 1, 1L },
                    { 315L, 5L, 9, 1, 1L },
                    { 261L, 4L, 12, 8, 1L },
                    { 186L, 4L, 12, 3, 1L },
                    { 185L, 4L, 11, 3, 1L },
                    { 184L, 4L, 10, 3, 1L },
                    { 91L, 3L, 5, 3, 1L },
                    { 92L, 3L, 6, 3, 1L },
                    { 93L, 3L, 7, 3, 1L },
                    { 94L, 3L, 8, 3, 1L },
                    { 95L, 3L, 9, 3, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 96L, 3L, 10, 3, 1L },
                    { 97L, 3L, 11, 3, 1L },
                    { 98L, 3L, 12, 3, 1L },
                    { 99L, 3L, 13, 3, 1L },
                    { 100L, 3L, 1, 4, 1L },
                    { 101L, 3L, 2, 4, 1L },
                    { 102L, 3L, 3, 4, 1L },
                    { 90L, 3L, 4, 3, 1L },
                    { 103L, 3L, 4, 4, 1L },
                    { 105L, 3L, 6, 4, 1L },
                    { 106L, 3L, 7, 4, 1L },
                    { 107L, 3L, 8, 4, 1L },
                    { 108L, 3L, 9, 4, 1L },
                    { 109L, 3L, 10, 4, 1L },
                    { 110L, 3L, 11, 4, 1L },
                    { 111L, 3L, 12, 4, 1L },
                    { 112L, 3L, 13, 4, 1L },
                    { 113L, 3L, 1, 5, 1L },
                    { 114L, 3L, 2, 5, 1L },
                    { 115L, 3L, 3, 5, 1L },
                    { 116L, 3L, 4, 5, 1L },
                    { 104L, 3L, 5, 4, 1L },
                    { 117L, 3L, 5, 5, 1L },
                    { 89L, 3L, 3, 3, 1L },
                    { 87L, 3L, 1, 3, 1L },
                    { 61L, 3L, 1, 1, 1L },
                    { 62L, 3L, 2, 1, 1L },
                    { 63L, 3L, 3, 1, 1L },
                    { 64L, 3L, 4, 1, 1L },
                    { 65L, 3L, 5, 1, 1L },
                    { 66L, 3L, 6, 1, 1L },
                    { 67L, 3L, 7, 1, 1L },
                    { 68L, 3L, 8, 1, 1L },
                    { 69L, 3L, 9, 1, 1L },
                    { 70L, 3L, 10, 1, 1L },
                    { 71L, 3L, 11, 1, 1L },
                    { 72L, 3L, 12, 1, 1L },
                    { 88L, 3L, 2, 3, 1L },
                    { 73L, 3L, 13, 1, 1L },
                    { 75L, 3L, 2, 2, 1L },
                    { 76L, 3L, 3, 2, 1L },
                    { 77L, 3L, 4, 2, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 78L, 3L, 5, 2, 1L },
                    { 79L, 3L, 6, 2, 1L },
                    { 80L, 3L, 7, 2, 1L },
                    { 81L, 3L, 8, 2, 1L },
                    { 82L, 3L, 9, 2, 1L },
                    { 83L, 3L, 10, 2, 1L },
                    { 84L, 3L, 11, 2, 1L },
                    { 85L, 3L, 12, 2, 1L },
                    { 86L, 3L, 13, 2, 1L },
                    { 74L, 3L, 1, 2, 1L },
                    { 118L, 3L, 6, 5, 1L },
                    { 119L, 3L, 7, 5, 1L },
                    { 120L, 3L, 8, 5, 1L },
                    { 158L, 4L, 14, 1, 1L },
                    { 159L, 4L, 15, 1, 1L },
                    { 160L, 4L, 1, 2, 1L },
                    { 161L, 4L, 2, 2, 1L },
                    { 162L, 4L, 3, 2, 1L },
                    { 163L, 4L, 4, 2, 1L },
                    { 164L, 4L, 5, 2, 1L },
                    { 165L, 4L, 6, 2, 1L },
                    { 166L, 4L, 7, 2, 1L },
                    { 167L, 4L, 8, 2, 1L },
                    { 168L, 4L, 9, 2, 1L },
                    { 169L, 4L, 10, 2, 1L },
                    { 157L, 4L, 13, 1, 1L },
                    { 170L, 4L, 11, 2, 1L },
                    { 172L, 4L, 13, 2, 1L },
                    { 173L, 4L, 14, 2, 1L },
                    { 174L, 4L, 15, 2, 1L },
                    { 175L, 4L, 1, 3, 1L },
                    { 176L, 4L, 2, 3, 1L },
                    { 177L, 4L, 3, 3, 1L },
                    { 178L, 4L, 4, 3, 1L },
                    { 179L, 4L, 5, 3, 1L },
                    { 180L, 4L, 6, 3, 1L },
                    { 181L, 4L, 7, 3, 1L },
                    { 182L, 4L, 8, 3, 1L },
                    { 183L, 4L, 9, 3, 1L },
                    { 171L, 4L, 12, 2, 1L },
                    { 156L, 4L, 12, 1, 1L },
                    { 155L, 4L, 11, 1, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 154L, 4L, 10, 1, 1L },
                    { 121L, 3L, 9, 5, 1L },
                    { 122L, 3L, 10, 5, 1L },
                    { 123L, 3L, 11, 5, 1L },
                    { 124L, 3L, 12, 5, 1L },
                    { 125L, 3L, 13, 5, 1L },
                    { 126L, 3L, 1, 6, 1L },
                    { 127L, 3L, 2, 6, 1L },
                    { 128L, 3L, 3, 6, 1L },
                    { 129L, 3L, 4, 6, 1L },
                    { 130L, 3L, 5, 6, 1L },
                    { 131L, 3L, 6, 6, 1L },
                    { 132L, 3L, 7, 6, 1L },
                    { 133L, 3L, 8, 6, 1L },
                    { 134L, 3L, 9, 6, 1L },
                    { 135L, 3L, 10, 6, 1L },
                    { 136L, 3L, 11, 6, 1L },
                    { 137L, 3L, 12, 6, 1L },
                    { 138L, 3L, 13, 6, 1L },
                    { 145L, 4L, 1, 1, 1L },
                    { 479L, 5L, 9, 11, 3L },
                    { 147L, 4L, 3, 1, 1L },
                    { 148L, 4L, 4, 1, 1L },
                    { 149L, 4L, 5, 1, 1L },
                    { 150L, 4L, 6, 1, 1L },
                    { 151L, 4L, 7, 1, 1L },
                    { 152L, 4L, 8, 1, 1L },
                    { 153L, 4L, 9, 1, 1L },
                    { 346L, 5L, 8, 3, 1L },
                    { 347L, 5L, 9, 3, 1L },
                    { 146L, 4L, 2, 1, 1L },
                    { 349L, 5L, 11, 3, 1L },
                    { 31L, 2L, 2, 1, 3L },
                    { 32L, 2L, 3, 1, 3L },
                    { 33L, 2L, 4, 1, 3L },
                    { 34L, 2L, 5, 1, 3L },
                    { 35L, 2L, 1, 2, 3L },
                    { 36L, 2L, 2, 2, 3L },
                    { 37L, 2L, 3, 2, 3L },
                    { 38L, 2L, 4, 2, 3L },
                    { 39L, 2L, 5, 2, 3L },
                    { 40L, 2L, 1, 3, 3L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 41L, 2L, 2, 3, 3L },
                    { 42L, 2L, 3, 3, 3L },
                    { 30L, 2L, 1, 1, 3L },
                    { 43L, 2L, 4, 3, 3L },
                    { 45L, 2L, 1, 4, 3L },
                    { 46L, 2L, 2, 4, 3L },
                    { 47L, 2L, 3, 4, 3L },
                    { 48L, 2L, 4, 4, 3L },
                    { 49L, 2L, 5, 4, 3L },
                    { 50L, 2L, 1, 5, 3L },
                    { 51L, 2L, 2, 5, 3L },
                    { 52L, 2L, 3, 5, 3L },
                    { 53L, 2L, 4, 5, 3L },
                    { 54L, 2L, 5, 5, 3L },
                    { 55L, 2L, 1, 6, 3L },
                    { 56L, 2L, 2, 6, 3L },
                    { 44L, 2L, 5, 3, 3L },
                    { 57L, 2L, 3, 6, 3L },
                    { 29L, 1L, 8, 4, 2L },
                    { 27L, 1L, 6, 4, 2L },
                    { 1L, 1L, 1, 1, 2L },
                    { 2L, 1L, 2, 1, 2L },
                    { 3L, 1L, 3, 1, 2L },
                    { 4L, 1L, 4, 1, 2L },
                    { 5L, 1L, 5, 1, 2L },
                    { 6L, 1L, 6, 1, 2L },
                    { 7L, 1L, 7, 1, 2L },
                    { 8L, 1L, 1, 2, 2L },
                    { 9L, 1L, 2, 2, 2L },
                    { 10L, 1L, 3, 2, 2L },
                    { 11L, 1L, 4, 2, 2L },
                    { 12L, 1L, 5, 2, 2L },
                    { 28L, 1L, 7, 4, 2L },
                    { 13L, 1L, 6, 2, 2L },
                    { 15L, 1L, 1, 3, 2L },
                    { 16L, 1L, 2, 3, 2L },
                    { 17L, 1L, 3, 3, 2L },
                    { 18L, 1L, 4, 3, 2L },
                    { 19L, 1L, 5, 3, 2L },
                    { 20L, 1L, 6, 3, 2L },
                    { 21L, 1L, 7, 3, 2L },
                    { 22L, 1L, 1, 4, 2L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 23L, 1L, 2, 4, 2L },
                    { 24L, 1L, 3, 4, 2L },
                    { 25L, 1L, 4, 4, 2L },
                    { 26L, 1L, 5, 4, 2L },
                    { 14L, 1L, 7, 2, 2L },
                    { 470L, 5L, 18, 10, 1L },
                    { 58L, 2L, 4, 6, 3L },
                    { 60L, 2L, 6, 6, 3L },
                    { 290L, 4L, 10, 10, 3L },
                    { 291L, 4L, 11, 10, 3L },
                    { 292L, 4L, 12, 10, 3L },
                    { 293L, 4L, 13, 10, 3L },
                    { 294L, 4L, 14, 10, 3L },
                    { 295L, 4L, 15, 10, 3L },
                    { 296L, 4L, 16, 10, 3L },
                    { 297L, 4L, 1, 11, 3L },
                    { 298L, 4L, 2, 11, 3L },
                    { 299L, 4L, 3, 11, 3L },
                    { 300L, 4L, 4, 11, 3L },
                    { 301L, 4L, 5, 11, 3L },
                    { 289L, 4L, 9, 10, 3L },
                    { 302L, 4L, 6, 11, 3L },
                    { 304L, 4L, 8, 11, 3L },
                    { 305L, 4L, 9, 11, 3L },
                    { 306L, 4L, 10, 11, 3L },
                    { 471L, 5L, 1, 11, 3L },
                    { 472L, 5L, 2, 11, 3L },
                    { 473L, 5L, 3, 11, 3L },
                    { 474L, 5L, 4, 11, 3L },
                    { 475L, 5L, 5, 11, 3L },
                    { 476L, 5L, 6, 11, 3L },
                    { 477L, 5L, 7, 11, 3L },
                    { 478L, 5L, 8, 11, 3L },
                    { 348L, 5L, 10, 3, 1L },
                    { 303L, 4L, 7, 11, 3L },
                    { 59L, 2L, 5, 6, 3L },
                    { 288L, 4L, 8, 10, 3L },
                    { 286L, 4L, 6, 10, 3L },
                    { 139L, 3L, 1, 7, 3L },
                    { 140L, 3L, 2, 7, 3L },
                    { 141L, 3L, 3, 7, 3L },
                    { 142L, 3L, 4, 7, 3L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 143L, 3L, 5, 7, 3L },
                    { 144L, 3L, 6, 7, 3L },
                    { 265L, 4L, 1, 9, 3L },
                    { 266L, 4L, 2, 9, 3L },
                    { 267L, 4L, 3, 9, 3L },
                    { 268L, 4L, 4, 9, 3L },
                    { 269L, 4L, 5, 9, 3L },
                    { 270L, 4L, 6, 9, 3L },
                    { 287L, 4L, 7, 10, 3L },
                    { 271L, 4L, 7, 9, 3L },
                    { 273L, 4L, 9, 9, 3L },
                    { 274L, 4L, 10, 9, 3L },
                    { 276L, 4L, 12, 9, 3L },
                    { 277L, 4L, 13, 9, 3L },
                    { 278L, 4L, 14, 9, 3L },
                    { 279L, 4L, 15, 9, 3L },
                    { 280L, 4L, 16, 9, 3L },
                    { 281L, 4L, 1, 10, 3L },
                    { 282L, 4L, 2, 10, 3L },
                    { 283L, 4L, 3, 10, 3L },
                    { 284L, 4L, 4, 10, 3L },
                    { 285L, 4L, 5, 10, 3L },
                    { 272L, 4L, 8, 9, 3L },
                    { 469L, 5L, 17, 10, 1L },
                    { 275L, 4L, 11, 9, 3L },
                    { 467L, 5L, 15, 10, 1L },
                    { 380L, 5L, 10, 5, 1L },
                    { 381L, 5L, 11, 5, 1L },
                    { 382L, 5L, 12, 5, 1L },
                    { 383L, 5L, 13, 5, 1L },
                    { 384L, 5L, 14, 5, 1L },
                    { 385L, 5L, 15, 5, 1L },
                    { 386L, 5L, 16, 5, 1L },
                    { 387L, 5L, 1, 6, 1L },
                    { 388L, 5L, 2, 6, 1L },
                    { 389L, 5L, 3, 6, 1L },
                    { 390L, 5L, 4, 6, 1L },
                    { 391L, 5L, 5, 6, 1L },
                    { 379L, 5L, 9, 5, 1L },
                    { 392L, 5L, 6, 6, 1L },
                    { 394L, 5L, 8, 6, 1L },
                    { 395L, 5L, 9, 6, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 396L, 5L, 10, 6, 1L },
                    { 397L, 5L, 11, 6, 1L },
                    { 398L, 5L, 12, 6, 1L },
                    { 399L, 5L, 13, 6, 1L },
                    { 400L, 5L, 14, 6, 1L },
                    { 401L, 5L, 15, 6, 1L },
                    { 402L, 5L, 16, 6, 1L },
                    { 403L, 5L, 1, 7, 1L },
                    { 404L, 5L, 2, 7, 1L },
                    { 405L, 5L, 3, 7, 1L },
                    { 393L, 5L, 7, 6, 1L },
                    { 406L, 5L, 4, 7, 1L },
                    { 378L, 5L, 8, 5, 1L },
                    { 376L, 5L, 6, 5, 1L },
                    { 350L, 5L, 12, 3, 1L },
                    { 468L, 5L, 16, 10, 1L },
                    { 351L, 5L, 13, 3, 1L },
                    { 352L, 5L, 14, 3, 1L },
                    { 353L, 5L, 15, 3, 1L },
                    { 354L, 5L, 16, 3, 1L },
                    { 355L, 5L, 1, 4, 1L },
                    { 356L, 5L, 2, 4, 1L },
                    { 357L, 5L, 3, 4, 1L },
                    { 358L, 5L, 4, 4, 1L },
                    { 359L, 5L, 5, 4, 1L },
                    { 360L, 5L, 6, 4, 1L },
                    { 377L, 5L, 7, 5, 1L },
                    { 361L, 5L, 7, 4, 1L },
                    { 363L, 5L, 9, 4, 1L },
                    { 364L, 5L, 10, 4, 1L },
                    { 365L, 5L, 11, 4, 1L },
                    { 366L, 5L, 12, 4, 1L },
                    { 367L, 5L, 13, 4, 1L },
                    { 368L, 5L, 14, 4, 1L },
                    { 369L, 5L, 15, 4, 1L },
                    { 371L, 5L, 1, 5, 1L },
                    { 372L, 5L, 2, 5, 1L },
                    { 373L, 5L, 3, 5, 1L },
                    { 374L, 5L, 4, 5, 1L },
                    { 375L, 5L, 5, 5, 1L },
                    { 362L, 5L, 8, 4, 1L },
                    { 407L, 5L, 5, 7, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 370L, 5L, 16, 4, 1L },
                    { 409L, 5L, 7, 7, 1L },
                    { 440L, 5L, 6, 9, 1L },
                    { 441L, 5L, 7, 9, 1L },
                    { 442L, 5L, 8, 9, 1L },
                    { 443L, 5L, 9, 9, 1L },
                    { 444L, 5L, 10, 9, 1L },
                    { 445L, 5L, 11, 9, 1L },
                    { 446L, 5L, 12, 9, 1L },
                    { 447L, 5L, 13, 9, 1L },
                    { 448L, 5L, 14, 9, 1L },
                    { 449L, 5L, 15, 9, 1L },
                    { 450L, 5L, 16, 9, 1L },
                    { 451L, 5L, 17, 9, 1L },
                    { 452L, 5L, 18, 9, 1L },
                    { 453L, 5L, 1, 10, 1L },
                    { 466L, 5L, 14, 10, 1L },
                    { 455L, 5L, 3, 10, 1L },
                    { 456L, 5L, 4, 10, 1L },
                    { 457L, 5L, 5, 10, 1L },
                    { 458L, 5L, 6, 10, 1L },
                    { 459L, 5L, 7, 10, 1L },
                    { 460L, 5L, 8, 10, 1L },
                    { 461L, 5L, 9, 10, 1L },
                    { 462L, 5L, 10, 10, 1L },
                    { 463L, 5L, 11, 10, 1L },
                    { 464L, 5L, 12, 10, 1L },
                    { 408L, 5L, 6, 7, 1L },
                    { 465L, 5L, 13, 10, 1L },
                    { 439L, 5L, 5, 9, 1L },
                    { 438L, 5L, 4, 9, 1L },
                    { 454L, 5L, 2, 10, 1L },
                    { 436L, 5L, 2, 9, 1L },
                    { 410L, 5L, 8, 7, 1L },
                    { 411L, 5L, 9, 7, 1L },
                    { 437L, 5L, 3, 9, 1L },
                    { 412L, 5L, 10, 7, 1L },
                    { 413L, 5L, 11, 7, 1L },
                    { 414L, 5L, 12, 7, 1L },
                    { 415L, 5L, 13, 7, 1L },
                    { 417L, 5L, 15, 7, 1L },
                    { 418L, 5L, 16, 7, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 419L, 5L, 1, 8, 1L },
                    { 420L, 5L, 2, 8, 1L },
                    { 421L, 5L, 3, 8, 1L },
                    { 422L, 5L, 4, 8, 1L },
                    { 423L, 5L, 5, 8, 1L },
                    { 416L, 5L, 14, 7, 1L },
                    { 425L, 5L, 7, 8, 1L },
                    { 424L, 5L, 6, 8, 1L },
                    { 434L, 5L, 16, 8, 1L },
                    { 432L, 5L, 14, 8, 1L },
                    { 431L, 5L, 13, 8, 1L },
                    { 433L, 5L, 15, 8, 1L },
                    { 430L, 5L, 12, 8, 1L },
                    { 429L, 5L, 11, 8, 1L },
                    { 428L, 5L, 10, 8, 1L },
                    { 427L, 5L, 9, 8, 1L },
                    { 435L, 5L, 1, 9, 1L },
                    { 426L, 5L, 8, 8, 1L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 45L, new DateTime(2022, 11, 13, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 50L, new DateTime(2022, 11, 13, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 55L, new DateTime(2022, 11, 13, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 60L, new DateTime(2022, 11, 13, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 40L, new DateTime(2022, 11, 12, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 65L, new DateTime(2022, 11, 13, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 85L, new DateTime(2022, 11, 14, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 75L, new DateTime(2022, 11, 13, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 80L, new DateTime(2022, 11, 13, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 90L, new DateTime(2022, 11, 14, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 95L, new DateTime(2022, 11, 14, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 100L, new DateTime(2022, 11, 14, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 110L, new DateTime(2022, 11, 14, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 35L, new DateTime(2022, 11, 12, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 105L, new DateTime(2022, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 70L, new DateTime(2022, 11, 13, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 30L, new DateTime(2022, 11, 12, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 1089L, new DateTime(2022, 12, 9, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 20L, new DateTime(2022, 11, 12, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 1059L, new DateTime(2022, 12, 8, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 1054L, new DateTime(2022, 12, 8, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 1064L, new DateTime(2022, 12, 8, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 1069L, new DateTime(2022, 12, 8, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 1074L, new DateTime(2022, 12, 8, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 1079L, new DateTime(2022, 12, 8, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 1084L, new DateTime(2022, 12, 9, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 25L, new DateTime(2022, 11, 12, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 1094L, new DateTime(2022, 12, 9, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 1104L, new DateTime(2022, 12, 9, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 1109L, new DateTime(2022, 12, 9, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 1114L, new DateTime(2022, 12, 9, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 1119L, new DateTime(2022, 12, 9, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 5L, new DateTime(2022, 11, 12, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 10L, new DateTime(2022, 11, 12, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 15L, new DateTime(2022, 11, 12, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 1099L, new DateTime(2022, 12, 9, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 115L, new DateTime(2022, 11, 14, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 255L, new DateTime(2022, 11, 18, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 125L, new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 235L, new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 240L, new DateTime(2022, 11, 17, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 245L, new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 250L, new DateTime(2022, 11, 18, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 260L, new DateTime(2022, 11, 18, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 265L, new DateTime(2022, 11, 18, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 270L, new DateTime(2022, 11, 18, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 230L, new DateTime(2022, 11, 17, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 275L, new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 285L, new DateTime(2022, 11, 19, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 290L, new DateTime(2022, 11, 19, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 295L, new DateTime(2022, 11, 19, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 300L, new DateTime(2022, 11, 19, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 305L, new DateTime(2022, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 1049L, new DateTime(2022, 12, 8, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 310L, new DateTime(2022, 11, 19, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 280L, new DateTime(2022, 11, 18, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 225L, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 220L, new DateTime(2022, 11, 17, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 215L, new DateTime(2022, 11, 17, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 130L, new DateTime(2022, 11, 15, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 135L, new DateTime(2022, 11, 15, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 140L, new DateTime(2022, 11, 15, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 145L, new DateTime(2022, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 150L, new DateTime(2022, 11, 15, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 155L, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 160L, new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 165L, new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 170L, new DateTime(2022, 11, 16, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 175L, new DateTime(2022, 11, 16, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 180L, new DateTime(2022, 11, 16, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 185L, new DateTime(2022, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 190L, new DateTime(2022, 11, 16, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 195L, new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 200L, new DateTime(2022, 11, 16, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 205L, new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 210L, new DateTime(2022, 11, 17, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 120L, new DateTime(2022, 11, 14, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 1044L, new DateTime(2022, 12, 8, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 754L, new DateTime(2022, 11, 30, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 1034L, new DateTime(2022, 12, 7, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 749L, new DateTime(2022, 11, 30, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 759L, new DateTime(2022, 11, 30, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 764L, new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 769L, new DateTime(2022, 12, 1, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 774L, new DateTime(2022, 12, 1, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 779L, new DateTime(2022, 12, 1, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 784L, new DateTime(2022, 12, 1, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 744L, new DateTime(2022, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 789L, new DateTime(2022, 12, 1, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 799L, new DateTime(2022, 12, 1, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 804L, new DateTime(2022, 12, 2, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 809L, new DateTime(2022, 12, 2, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 814L, new DateTime(2022, 12, 2, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 819L, new DateTime(2022, 12, 2, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 824L, new DateTime(2022, 12, 2, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 829L, new DateTime(2022, 12, 2, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 794L, new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 834L, new DateTime(2022, 12, 2, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 739L, new DateTime(2022, 11, 30, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 729L, new DateTime(2022, 11, 30, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 315L, new DateTime(2022, 11, 19, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 654L, new DateTime(2022, 11, 28, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 659L, new DateTime(2022, 11, 28, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 664L, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 669L, new DateTime(2022, 11, 28, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 674L, new DateTime(2022, 11, 28, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 679L, new DateTime(2022, 11, 28, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 734L, new DateTime(2022, 11, 30, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 684L, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 694L, new DateTime(2022, 11, 29, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 699L, new DateTime(2022, 11, 29, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 704L, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 709L, new DateTime(2022, 11, 29, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 714L, new DateTime(2022, 11, 29, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 719L, new DateTime(2022, 11, 29, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 724L, new DateTime(2022, 11, 30, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 689L, new DateTime(2022, 11, 29, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 1039L, new DateTime(2022, 12, 7, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 839L, new DateTime(2022, 12, 2, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 849L, new DateTime(2022, 12, 3, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 954L, new DateTime(2022, 12, 5, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 959L, new DateTime(2022, 12, 5, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 964L, new DateTime(2022, 12, 6, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 969L, new DateTime(2022, 12, 6, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 974L, new DateTime(2022, 12, 6, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 979L, new DateTime(2022, 12, 6, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 984L, new DateTime(2022, 12, 6, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 949L, new DateTime(2022, 12, 5, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 989L, new DateTime(2022, 12, 6, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 999L, new DateTime(2022, 12, 6, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 1004L, new DateTime(2022, 12, 7, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 1009L, new DateTime(2022, 12, 7, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 1014L, new DateTime(2022, 12, 7, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 1019L, new DateTime(2022, 12, 7, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 1024L, new DateTime(2022, 12, 7, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 1029L, new DateTime(2022, 12, 7, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 994L, new DateTime(2022, 12, 6, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 844L, new DateTime(2022, 12, 3, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 944L, new DateTime(2022, 12, 5, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 934L, new DateTime(2022, 12, 5, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 854L, new DateTime(2022, 12, 3, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 859L, new DateTime(2022, 12, 3, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 864L, new DateTime(2022, 12, 3, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 869L, new DateTime(2022, 12, 3, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 874L, new DateTime(2022, 12, 3, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 879L, new DateTime(2022, 12, 3, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 884L, new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 939L, new DateTime(2022, 12, 5, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 889L, new DateTime(2022, 12, 4, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 899L, new DateTime(2022, 12, 4, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 904L, new DateTime(2022, 12, 4, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 909L, new DateTime(2022, 12, 4, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 914L, new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 919L, new DateTime(2022, 12, 4, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 924L, new DateTime(2022, 12, 5, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 929L, new DateTime(2022, 12, 5, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 894L, new DateTime(2022, 12, 4, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 320L, new DateTime(2022, 11, 19, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 920L, new DateTime(2022, 12, 4, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 330L, new DateTime(2022, 11, 20, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 840L, new DateTime(2022, 12, 2, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 845L, new DateTime(2022, 12, 3, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 850L, new DateTime(2022, 12, 3, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 855L, new DateTime(2022, 12, 3, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 860L, new DateTime(2022, 12, 3, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 865L, new DateTime(2022, 12, 3, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 870L, new DateTime(2022, 12, 3, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 835L, new DateTime(2022, 12, 2, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 875L, new DateTime(2022, 12, 3, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 885L, new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 890L, new DateTime(2022, 12, 4, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 895L, new DateTime(2022, 12, 4, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 900L, new DateTime(2022, 12, 4, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 905L, new DateTime(2022, 12, 4, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 910L, new DateTime(2022, 12, 4, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 915L, new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 880L, new DateTime(2022, 12, 3, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 925L, new DateTime(2022, 12, 5, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 830L, new DateTime(2022, 12, 2, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 820L, new DateTime(2022, 12, 2, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 740L, new DateTime(2022, 11, 30, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 745L, new DateTime(2022, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 750L, new DateTime(2022, 11, 30, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 755L, new DateTime(2022, 11, 30, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 760L, new DateTime(2022, 11, 30, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 765L, new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 770L, new DateTime(2022, 12, 1, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 825L, new DateTime(2022, 12, 2, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 775L, new DateTime(2022, 12, 1, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 785L, new DateTime(2022, 12, 1, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 790L, new DateTime(2022, 12, 1, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 795L, new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 800L, new DateTime(2022, 12, 1, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 805L, new DateTime(2022, 12, 2, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 810L, new DateTime(2022, 12, 2, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 815L, new DateTime(2022, 12, 2, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 780L, new DateTime(2022, 12, 1, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 735L, new DateTime(2022, 11, 30, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 930L, new DateTime(2022, 12, 5, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 940L, new DateTime(2022, 12, 5, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 1045L, new DateTime(2022, 12, 8, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 1050L, new DateTime(2022, 12, 8, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 1055L, new DateTime(2022, 12, 8, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 1060L, new DateTime(2022, 12, 8, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 1065L, new DateTime(2022, 12, 8, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 1070L, new DateTime(2022, 12, 8, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 1075L, new DateTime(2022, 12, 8, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 1040L, new DateTime(2022, 12, 7, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 1080L, new DateTime(2022, 12, 8, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 1090L, new DateTime(2022, 12, 9, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 1095L, new DateTime(2022, 12, 9, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 1100L, new DateTime(2022, 12, 9, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 1105L, new DateTime(2022, 12, 9, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 1110L, new DateTime(2022, 12, 9, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 1115L, new DateTime(2022, 12, 9, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 1120L, new DateTime(2022, 12, 9, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 1085L, new DateTime(2022, 12, 9, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 935L, new DateTime(2022, 12, 5, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 1035L, new DateTime(2022, 12, 7, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 1025L, new DateTime(2022, 12, 7, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 945L, new DateTime(2022, 12, 5, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 950L, new DateTime(2022, 12, 5, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 955L, new DateTime(2022, 12, 5, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 960L, new DateTime(2022, 12, 5, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 965L, new DateTime(2022, 12, 6, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 970L, new DateTime(2022, 12, 6, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 975L, new DateTime(2022, 12, 6, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 1030L, new DateTime(2022, 12, 7, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 980L, new DateTime(2022, 12, 6, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 990L, new DateTime(2022, 12, 6, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 995L, new DateTime(2022, 12, 6, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 1000L, new DateTime(2022, 12, 6, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 1005L, new DateTime(2022, 12, 7, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 1010L, new DateTime(2022, 12, 7, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 1015L, new DateTime(2022, 12, 7, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 1020L, new DateTime(2022, 12, 7, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 985L, new DateTime(2022, 12, 6, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 730L, new DateTime(2022, 11, 30, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 725L, new DateTime(2022, 11, 30, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 720L, new DateTime(2022, 11, 29, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 435L, new DateTime(2022, 11, 22, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 440L, new DateTime(2022, 11, 22, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 445L, new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 450L, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 455L, new DateTime(2022, 11, 23, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 460L, new DateTime(2022, 11, 23, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 465L, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 430L, new DateTime(2022, 11, 22, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 470L, new DateTime(2022, 11, 23, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 480L, new DateTime(2022, 11, 23, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 485L, new DateTime(2022, 11, 24, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 490L, new DateTime(2022, 11, 24, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 495L, new DateTime(2022, 11, 24, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 500L, new DateTime(2022, 11, 24, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 505L, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 510L, new DateTime(2022, 11, 24, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 475L, new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 515L, new DateTime(2022, 11, 24, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 425L, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 415L, new DateTime(2022, 11, 22, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 335L, new DateTime(2022, 11, 20, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 340L, new DateTime(2022, 11, 20, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 345L, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 350L, new DateTime(2022, 11, 20, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 355L, new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 360L, new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 365L, new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 420L, new DateTime(2022, 11, 22, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 370L, new DateTime(2022, 11, 21, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 380L, new DateTime(2022, 11, 21, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 385L, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 390L, new DateTime(2022, 11, 21, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 395L, new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 400L, new DateTime(2022, 11, 21, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 405L, new DateTime(2022, 11, 22, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 410L, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 375L, new DateTime(2022, 11, 21, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 520L, new DateTime(2022, 11, 24, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 525L, new DateTime(2022, 11, 25, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 530L, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 640L, new DateTime(2022, 11, 27, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 645L, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 650L, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 655L, new DateTime(2022, 11, 28, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 660L, new DateTime(2022, 11, 28, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 665L, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 670L, new DateTime(2022, 11, 28, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 635L, new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 675L, new DateTime(2022, 11, 28, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 685L, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 690L, new DateTime(2022, 11, 29, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 695L, new DateTime(2022, 11, 29, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 700L, new DateTime(2022, 11, 29, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 705L, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 710L, new DateTime(2022, 11, 29, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 715L, new DateTime(2022, 11, 29, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 680L, new DateTime(2022, 11, 28, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 630L, new DateTime(2022, 11, 27, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 625L, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 620L, new DateTime(2022, 11, 27, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 535L, new DateTime(2022, 11, 25, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 540L, new DateTime(2022, 11, 25, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 545L, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 550L, new DateTime(2022, 11, 25, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 555L, new DateTime(2022, 11, 25, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 560L, new DateTime(2022, 11, 25, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 565L, new DateTime(2022, 11, 26, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 570L, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 575L, new DateTime(2022, 11, 26, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 580L, new DateTime(2022, 11, 26, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 585L, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 590L, new DateTime(2022, 11, 26, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 595L, new DateTime(2022, 11, 26, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 600L, new DateTime(2022, 11, 26, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 605L, new DateTime(2022, 11, 27, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 610L, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 615L, new DateTime(2022, 11, 27, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 325L, new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 644L, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 649L, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 634L, new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 242L, new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 237L, new DateTime(2022, 11, 17, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 232L, new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 227L, new DateTime(2022, 11, 17, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 222L, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 217L, new DateTime(2022, 11, 17, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 212L, new DateTime(2022, 11, 17, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 207L, new DateTime(2022, 11, 17, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 202L, new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 197L, new DateTime(2022, 11, 16, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 192L, new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 187L, new DateTime(2022, 11, 16, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 182L, new DateTime(2022, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 177L, new DateTime(2022, 11, 16, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 172L, new DateTime(2022, 11, 16, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 167L, new DateTime(2022, 11, 16, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 162L, new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 157L, new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 152L, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 147L, new DateTime(2022, 11, 15, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 142L, new DateTime(2022, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 247L, new DateTime(2022, 11, 18, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 137L, new DateTime(2022, 11, 15, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 252L, new DateTime(2022, 11, 18, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 262L, new DateTime(2022, 11, 18, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 367L, new DateTime(2022, 11, 21, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 362L, new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 357L, new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 352L, new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 347L, new DateTime(2022, 11, 20, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 342L, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 337L, new DateTime(2022, 11, 20, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 332L, new DateTime(2022, 11, 20, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 327L, new DateTime(2022, 11, 20, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 322L, new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 317L, new DateTime(2022, 11, 19, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 312L, new DateTime(2022, 11, 19, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 307L, new DateTime(2022, 11, 19, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 302L, new DateTime(2022, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 297L, new DateTime(2022, 11, 19, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 292L, new DateTime(2022, 11, 19, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 287L, new DateTime(2022, 11, 19, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 282L, new DateTime(2022, 11, 19, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 277L, new DateTime(2022, 11, 18, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 272L, new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 267L, new DateTime(2022, 11, 18, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 257L, new DateTime(2022, 11, 18, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 372L, new DateTime(2022, 11, 21, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 132L, new DateTime(2022, 11, 15, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 122L, new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 1111L, new DateTime(2022, 12, 9, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 1106L, new DateTime(2022, 12, 9, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 1101L, new DateTime(2022, 12, 9, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 1096L, new DateTime(2022, 12, 9, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 1091L, new DateTime(2022, 12, 9, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 1086L, new DateTime(2022, 12, 9, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 1081L, new DateTime(2022, 12, 9, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 1076L, new DateTime(2022, 12, 8, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 1071L, new DateTime(2022, 12, 8, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 1066L, new DateTime(2022, 12, 8, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 1061L, new DateTime(2022, 12, 8, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 1056L, new DateTime(2022, 12, 8, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 1051L, new DateTime(2022, 12, 8, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 1046L, new DateTime(2022, 12, 8, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 1041L, new DateTime(2022, 12, 8, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 1036L, new DateTime(2022, 12, 7, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 1031L, new DateTime(2022, 12, 7, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 1026L, new DateTime(2022, 12, 7, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 1021L, new DateTime(2022, 12, 7, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 1016L, new DateTime(2022, 12, 7, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 1011L, new DateTime(2022, 12, 7, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 1116L, new DateTime(2022, 12, 9, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 127L, new DateTime(2022, 11, 15, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 2L, new DateTime(2022, 11, 12, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 12L, new DateTime(2022, 11, 12, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 117L, new DateTime(2022, 11, 14, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 112L, new DateTime(2022, 11, 14, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 107L, new DateTime(2022, 11, 14, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 102L, new DateTime(2022, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 97L, new DateTime(2022, 11, 14, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 92L, new DateTime(2022, 11, 14, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 87L, new DateTime(2022, 11, 14, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 82L, new DateTime(2022, 11, 14, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 77L, new DateTime(2022, 11, 13, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 72L, new DateTime(2022, 11, 13, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 67L, new DateTime(2022, 11, 13, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 62L, new DateTime(2022, 11, 13, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 57L, new DateTime(2022, 11, 13, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 52L, new DateTime(2022, 11, 13, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 47L, new DateTime(2022, 11, 13, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 42L, new DateTime(2022, 11, 13, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 37L, new DateTime(2022, 11, 12, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 32L, new DateTime(2022, 11, 12, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 27L, new DateTime(2022, 11, 12, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 22L, new DateTime(2022, 11, 12, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 17L, new DateTime(2022, 11, 12, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 7L, new DateTime(2022, 11, 12, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 377L, new DateTime(2022, 11, 21, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 382L, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 387L, new DateTime(2022, 11, 21, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 747L, new DateTime(2022, 11, 30, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 742L, new DateTime(2022, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 737L, new DateTime(2022, 11, 30, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 732L, new DateTime(2022, 11, 30, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 727L, new DateTime(2022, 11, 30, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 722L, new DateTime(2022, 11, 30, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 717L, new DateTime(2022, 11, 29, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 712L, new DateTime(2022, 11, 29, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 707L, new DateTime(2022, 11, 29, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 702L, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 697L, new DateTime(2022, 11, 29, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 692L, new DateTime(2022, 11, 29, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 687L, new DateTime(2022, 11, 29, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 682L, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 677L, new DateTime(2022, 11, 28, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 672L, new DateTime(2022, 11, 28, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 667L, new DateTime(2022, 11, 28, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 662L, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 657L, new DateTime(2022, 11, 28, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 652L, new DateTime(2022, 11, 28, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 647L, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 752L, new DateTime(2022, 11, 30, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 642L, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 757L, new DateTime(2022, 11, 30, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 767L, new DateTime(2022, 12, 1, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 872L, new DateTime(2022, 12, 3, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 867L, new DateTime(2022, 12, 3, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 862L, new DateTime(2022, 12, 3, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 857L, new DateTime(2022, 12, 3, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 852L, new DateTime(2022, 12, 3, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 847L, new DateTime(2022, 12, 3, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 842L, new DateTime(2022, 12, 3, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 837L, new DateTime(2022, 12, 2, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 832L, new DateTime(2022, 12, 2, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 827L, new DateTime(2022, 12, 2, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 822L, new DateTime(2022, 12, 2, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 817L, new DateTime(2022, 12, 2, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 812L, new DateTime(2022, 12, 2, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 807L, new DateTime(2022, 12, 2, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 802L, new DateTime(2022, 12, 2, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 797L, new DateTime(2022, 12, 1, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 792L, new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 787L, new DateTime(2022, 12, 1, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 782L, new DateTime(2022, 12, 1, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 777L, new DateTime(2022, 12, 1, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 772L, new DateTime(2022, 12, 1, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 762L, new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 637L, new DateTime(2022, 11, 27, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 632L, new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 627L, new DateTime(2022, 11, 27, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 492L, new DateTime(2022, 11, 24, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 487L, new DateTime(2022, 11, 24, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 482L, new DateTime(2022, 11, 24, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 477L, new DateTime(2022, 11, 23, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 472L, new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 467L, new DateTime(2022, 11, 23, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 462L, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 457L, new DateTime(2022, 11, 23, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 452L, new DateTime(2022, 11, 23, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 447L, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 442L, new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 437L, new DateTime(2022, 11, 22, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 432L, new DateTime(2022, 11, 22, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 427L, new DateTime(2022, 11, 22, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 422L, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 417L, new DateTime(2022, 11, 22, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 412L, new DateTime(2022, 11, 22, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 407L, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 402L, new DateTime(2022, 11, 22, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 397L, new DateTime(2022, 11, 21, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 392L, new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 497L, new DateTime(2022, 11, 24, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 502L, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 507L, new DateTime(2022, 11, 24, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 512L, new DateTime(2022, 11, 24, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 622L, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 617L, new DateTime(2022, 11, 27, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 612L, new DateTime(2022, 11, 27, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 607L, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 602L, new DateTime(2022, 11, 27, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 597L, new DateTime(2022, 11, 26, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 592L, new DateTime(2022, 11, 26, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 587L, new DateTime(2022, 11, 26, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 582L, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 577L, new DateTime(2022, 11, 26, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 1006L, new DateTime(2022, 12, 7, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 572L, new DateTime(2022, 11, 26, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 562L, new DateTime(2022, 11, 26, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 557L, new DateTime(2022, 11, 25, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 552L, new DateTime(2022, 11, 25, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 547L, new DateTime(2022, 11, 25, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 542L, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 537L, new DateTime(2022, 11, 25, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 532L, new DateTime(2022, 11, 25, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 527L, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 522L, new DateTime(2022, 11, 25, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 517L, new DateTime(2022, 11, 24, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 567L, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 877L, new DateTime(2022, 12, 3, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 1001L, new DateTime(2022, 12, 7, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 991L, new DateTime(2022, 12, 6, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 356L, new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 351L, new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 346L, new DateTime(2022, 11, 20, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 341L, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 336L, new DateTime(2022, 11, 20, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 331L, new DateTime(2022, 11, 20, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 326L, new DateTime(2022, 11, 20, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 321L, new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 316L, new DateTime(2022, 11, 19, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 311L, new DateTime(2022, 11, 19, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 306L, new DateTime(2022, 11, 19, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 301L, new DateTime(2022, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 296L, new DateTime(2022, 11, 19, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 291L, new DateTime(2022, 11, 19, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 286L, new DateTime(2022, 11, 19, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 281L, new DateTime(2022, 11, 19, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 276L, new DateTime(2022, 11, 18, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 271L, new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 266L, new DateTime(2022, 11, 18, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 261L, new DateTime(2022, 11, 18, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 256L, new DateTime(2022, 11, 18, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 361L, new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 251L, new DateTime(2022, 11, 18, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 366L, new DateTime(2022, 11, 21, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 376L, new DateTime(2022, 11, 21, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 481L, new DateTime(2022, 11, 24, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 476L, new DateTime(2022, 11, 23, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 471L, new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 466L, new DateTime(2022, 11, 23, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 461L, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 456L, new DateTime(2022, 11, 23, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 451L, new DateTime(2022, 11, 23, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 446L, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 441L, new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 436L, new DateTime(2022, 11, 22, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 431L, new DateTime(2022, 11, 22, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 426L, new DateTime(2022, 11, 22, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 421L, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 416L, new DateTime(2022, 11, 22, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 411L, new DateTime(2022, 11, 22, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 406L, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 401L, new DateTime(2022, 11, 22, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 396L, new DateTime(2022, 11, 21, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 391L, new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 386L, new DateTime(2022, 11, 21, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 381L, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 371L, new DateTime(2022, 11, 21, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 486L, new DateTime(2022, 11, 24, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 246L, new DateTime(2022, 11, 18, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 236L, new DateTime(2022, 11, 17, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 106L, new DateTime(2022, 11, 14, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 101L, new DateTime(2022, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 96L, new DateTime(2022, 11, 14, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 91L, new DateTime(2022, 11, 14, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 86L, new DateTime(2022, 11, 14, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 81L, new DateTime(2022, 11, 14, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 76L, new DateTime(2022, 11, 13, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 71L, new DateTime(2022, 11, 13, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 66L, new DateTime(2022, 11, 13, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 61L, new DateTime(2022, 11, 13, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 56L, new DateTime(2022, 11, 13, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 51L, new DateTime(2022, 11, 13, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 46L, new DateTime(2022, 11, 13, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 41L, new DateTime(2022, 11, 13, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 36L, new DateTime(2022, 11, 12, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 31L, new DateTime(2022, 11, 12, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 26L, new DateTime(2022, 11, 12, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 21L, new DateTime(2022, 11, 12, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 16L, new DateTime(2022, 11, 12, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 11L, new DateTime(2022, 11, 12, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 6L, new DateTime(2022, 11, 12, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 111L, new DateTime(2022, 11, 14, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 241L, new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 116L, new DateTime(2022, 11, 14, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 126L, new DateTime(2022, 11, 15, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 231L, new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 226L, new DateTime(2022, 11, 17, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 221L, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 216L, new DateTime(2022, 11, 17, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 211L, new DateTime(2022, 11, 17, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 206L, new DateTime(2022, 11, 17, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 201L, new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 196L, new DateTime(2022, 11, 16, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 191L, new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 186L, new DateTime(2022, 11, 16, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 181L, new DateTime(2022, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 176L, new DateTime(2022, 11, 16, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 171L, new DateTime(2022, 11, 16, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 166L, new DateTime(2022, 11, 16, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 161L, new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 156L, new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 151L, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 146L, new DateTime(2022, 11, 15, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 141L, new DateTime(2022, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 136L, new DateTime(2022, 11, 15, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 131L, new DateTime(2022, 11, 15, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 121L, new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 491L, new DateTime(2022, 11, 24, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 496L, new DateTime(2022, 11, 24, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 501L, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 861L, new DateTime(2022, 12, 3, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 856L, new DateTime(2022, 12, 3, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 851L, new DateTime(2022, 12, 3, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 846L, new DateTime(2022, 12, 3, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 841L, new DateTime(2022, 12, 3, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 836L, new DateTime(2022, 12, 2, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 831L, new DateTime(2022, 12, 2, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 826L, new DateTime(2022, 12, 2, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 821L, new DateTime(2022, 12, 2, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 816L, new DateTime(2022, 12, 2, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 811L, new DateTime(2022, 12, 2, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 806L, new DateTime(2022, 12, 2, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 801L, new DateTime(2022, 12, 2, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 796L, new DateTime(2022, 12, 1, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 791L, new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 786L, new DateTime(2022, 12, 1, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 781L, new DateTime(2022, 12, 1, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 776L, new DateTime(2022, 12, 1, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 771L, new DateTime(2022, 12, 1, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 766L, new DateTime(2022, 12, 1, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 761L, new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 866L, new DateTime(2022, 12, 3, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 756L, new DateTime(2022, 11, 30, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 871L, new DateTime(2022, 12, 3, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 881L, new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 986L, new DateTime(2022, 12, 6, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 981L, new DateTime(2022, 12, 6, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 976L, new DateTime(2022, 12, 6, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 971L, new DateTime(2022, 12, 6, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 966L, new DateTime(2022, 12, 6, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 961L, new DateTime(2022, 12, 6, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 956L, new DateTime(2022, 12, 5, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 951L, new DateTime(2022, 12, 5, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 946L, new DateTime(2022, 12, 5, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 941L, new DateTime(2022, 12, 5, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 936L, new DateTime(2022, 12, 5, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 931L, new DateTime(2022, 12, 5, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 926L, new DateTime(2022, 12, 5, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 921L, new DateTime(2022, 12, 5, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 916L, new DateTime(2022, 12, 4, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 911L, new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 906L, new DateTime(2022, 12, 4, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 901L, new DateTime(2022, 12, 4, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 896L, new DateTime(2022, 12, 4, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 891L, new DateTime(2022, 12, 4, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 886L, new DateTime(2022, 12, 4, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 876L, new DateTime(2022, 12, 3, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 751L, new DateTime(2022, 11, 30, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 746L, new DateTime(2022, 11, 30, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 741L, new DateTime(2022, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 606L, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 601L, new DateTime(2022, 11, 27, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 596L, new DateTime(2022, 11, 26, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 591L, new DateTime(2022, 11, 26, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 586L, new DateTime(2022, 11, 26, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 581L, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 576L, new DateTime(2022, 11, 26, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 571L, new DateTime(2022, 11, 26, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 566L, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 561L, new DateTime(2022, 11, 26, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 556L, new DateTime(2022, 11, 25, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 551L, new DateTime(2022, 11, 25, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 546L, new DateTime(2022, 11, 25, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 541L, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 536L, new DateTime(2022, 11, 25, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 531L, new DateTime(2022, 11, 25, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 526L, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 521L, new DateTime(2022, 11, 25, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 516L, new DateTime(2022, 11, 24, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 511L, new DateTime(2022, 11, 24, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 506L, new DateTime(2022, 11, 24, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 611L, new DateTime(2022, 11, 27, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 616L, new DateTime(2022, 11, 27, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 621L, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 626L, new DateTime(2022, 11, 27, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 736L, new DateTime(2022, 11, 30, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 731L, new DateTime(2022, 11, 30, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 726L, new DateTime(2022, 11, 30, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 721L, new DateTime(2022, 11, 30, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 716L, new DateTime(2022, 11, 29, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 711L, new DateTime(2022, 11, 29, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 706L, new DateTime(2022, 11, 29, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 701L, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 696L, new DateTime(2022, 11, 29, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 691L, new DateTime(2022, 11, 29, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 996L, new DateTime(2022, 12, 6, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 686L, new DateTime(2022, 11, 29, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 676L, new DateTime(2022, 11, 28, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 671L, new DateTime(2022, 11, 28, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 666L, new DateTime(2022, 11, 28, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 661L, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 656L, new DateTime(2022, 11, 28, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 651L, new DateTime(2022, 11, 28, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 646L, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 641L, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 636L, new DateTime(2022, 11, 27, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 631L, new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 681L, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 639L, new DateTime(2022, 11, 27, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 882L, new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 892L, new DateTime(2022, 12, 4, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 1118L, new DateTime(2022, 12, 9, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 1113L, new DateTime(2022, 12, 9, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 1108L, new DateTime(2022, 12, 9, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 1103L, new DateTime(2022, 12, 9, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 1098L, new DateTime(2022, 12, 9, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 1093L, new DateTime(2022, 12, 9, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 1088L, new DateTime(2022, 12, 9, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 1083L, new DateTime(2022, 12, 9, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 1078L, new DateTime(2022, 12, 8, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 1073L, new DateTime(2022, 12, 8, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 1068L, new DateTime(2022, 12, 8, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 1063L, new DateTime(2022, 12, 8, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 1058L, new DateTime(2022, 12, 8, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 1053L, new DateTime(2022, 12, 8, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 1048L, new DateTime(2022, 12, 8, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 1043L, new DateTime(2022, 12, 8, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 1038L, new DateTime(2022, 12, 7, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 1033L, new DateTime(2022, 12, 7, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 1028L, new DateTime(2022, 12, 7, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 1023L, new DateTime(2022, 12, 7, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 1018L, new DateTime(2022, 12, 7, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 4L, new DateTime(2022, 11, 12, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 1013L, new DateTime(2022, 12, 7, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 9L, new DateTime(2022, 11, 12, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 19L, new DateTime(2022, 11, 12, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 124L, new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 119L, new DateTime(2022, 11, 14, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 114L, new DateTime(2022, 11, 14, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 109L, new DateTime(2022, 11, 14, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 104L, new DateTime(2022, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 99L, new DateTime(2022, 11, 14, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 94L, new DateTime(2022, 11, 14, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 89L, new DateTime(2022, 11, 14, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 84L, new DateTime(2022, 11, 14, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 79L, new DateTime(2022, 11, 13, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 74L, new DateTime(2022, 11, 13, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 69L, new DateTime(2022, 11, 13, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 64L, new DateTime(2022, 11, 13, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 59L, new DateTime(2022, 11, 13, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 54L, new DateTime(2022, 11, 13, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 49L, new DateTime(2022, 11, 13, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 44L, new DateTime(2022, 11, 13, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 39L, new DateTime(2022, 11, 12, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 34L, new DateTime(2022, 11, 12, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 29L, new DateTime(2022, 11, 12, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 24L, new DateTime(2022, 11, 12, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 14L, new DateTime(2022, 11, 12, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 129L, new DateTime(2022, 11, 15, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 1008L, new DateTime(2022, 12, 7, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 998L, new DateTime(2022, 12, 6, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 868L, new DateTime(2022, 12, 3, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 863L, new DateTime(2022, 12, 3, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 858L, new DateTime(2022, 12, 3, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 853L, new DateTime(2022, 12, 3, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 848L, new DateTime(2022, 12, 3, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 843L, new DateTime(2022, 12, 3, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 838L, new DateTime(2022, 12, 2, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 833L, new DateTime(2022, 12, 2, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 828L, new DateTime(2022, 12, 2, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 823L, new DateTime(2022, 12, 2, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 818L, new DateTime(2022, 12, 2, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 813L, new DateTime(2022, 12, 2, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 808L, new DateTime(2022, 12, 2, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 803L, new DateTime(2022, 12, 2, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 798L, new DateTime(2022, 12, 1, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 793L, new DateTime(2022, 12, 1, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 788L, new DateTime(2022, 12, 1, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 783L, new DateTime(2022, 12, 1, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 778L, new DateTime(2022, 12, 1, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 773L, new DateTime(2022, 12, 1, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 768L, new DateTime(2022, 12, 1, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 873L, new DateTime(2022, 12, 3, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 1003L, new DateTime(2022, 12, 7, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 878L, new DateTime(2022, 12, 3, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 888L, new DateTime(2022, 12, 4, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 993L, new DateTime(2022, 12, 6, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 988L, new DateTime(2022, 12, 6, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 983L, new DateTime(2022, 12, 6, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 978L, new DateTime(2022, 12, 6, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 973L, new DateTime(2022, 12, 6, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 968L, new DateTime(2022, 12, 6, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 963L, new DateTime(2022, 12, 6, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 958L, new DateTime(2022, 12, 5, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 953L, new DateTime(2022, 12, 5, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 948L, new DateTime(2022, 12, 5, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 943L, new DateTime(2022, 12, 5, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 938L, new DateTime(2022, 12, 5, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 933L, new DateTime(2022, 12, 5, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 928L, new DateTime(2022, 12, 5, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 923L, new DateTime(2022, 12, 5, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 918L, new DateTime(2022, 12, 4, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 913L, new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 908L, new DateTime(2022, 12, 4, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 903L, new DateTime(2022, 12, 4, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 898L, new DateTime(2022, 12, 4, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 893L, new DateTime(2022, 12, 4, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 883L, new DateTime(2022, 12, 4, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 134L, new DateTime(2022, 11, 15, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 139L, new DateTime(2022, 11, 15, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 144L, new DateTime(2022, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 504L, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 499L, new DateTime(2022, 11, 24, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 494L, new DateTime(2022, 11, 24, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 489L, new DateTime(2022, 11, 24, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 484L, new DateTime(2022, 11, 24, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 479L, new DateTime(2022, 11, 23, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 474L, new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 469L, new DateTime(2022, 11, 23, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 464L, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 459L, new DateTime(2022, 11, 23, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 454L, new DateTime(2022, 11, 23, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 449L, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 444L, new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 439L, new DateTime(2022, 11, 22, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 434L, new DateTime(2022, 11, 22, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 429L, new DateTime(2022, 11, 22, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 424L, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 419L, new DateTime(2022, 11, 22, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 414L, new DateTime(2022, 11, 22, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 409L, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 404L, new DateTime(2022, 11, 22, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 509L, new DateTime(2022, 11, 24, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 399L, new DateTime(2022, 11, 21, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 514L, new DateTime(2022, 11, 24, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 524L, new DateTime(2022, 11, 25, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 629L, new DateTime(2022, 11, 27, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 624L, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 619L, new DateTime(2022, 11, 27, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 614L, new DateTime(2022, 11, 27, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 609L, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 604L, new DateTime(2022, 11, 27, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 599L, new DateTime(2022, 11, 26, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 594L, new DateTime(2022, 11, 26, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 589L, new DateTime(2022, 11, 26, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 584L, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 579L, new DateTime(2022, 11, 26, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 574L, new DateTime(2022, 11, 26, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 569L, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 564L, new DateTime(2022, 11, 26, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 559L, new DateTime(2022, 11, 25, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 554L, new DateTime(2022, 11, 25, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 549L, new DateTime(2022, 11, 25, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 544L, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 539L, new DateTime(2022, 11, 25, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 534L, new DateTime(2022, 11, 25, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 529L, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 519L, new DateTime(2022, 11, 24, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 394L, new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 389L, new DateTime(2022, 11, 21, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 384L, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 249L, new DateTime(2022, 11, 18, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 244L, new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 239L, new DateTime(2022, 11, 17, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 234L, new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 229L, new DateTime(2022, 11, 17, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 224L, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 219L, new DateTime(2022, 11, 17, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 214L, new DateTime(2022, 11, 17, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 209L, new DateTime(2022, 11, 17, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 204L, new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 199L, new DateTime(2022, 11, 16, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 194L, new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 189L, new DateTime(2022, 11, 16, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 184L, new DateTime(2022, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 179L, new DateTime(2022, 11, 16, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 174L, new DateTime(2022, 11, 16, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 169L, new DateTime(2022, 11, 16, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 164L, new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 159L, new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 154L, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 149L, new DateTime(2022, 11, 15, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 254L, new DateTime(2022, 11, 18, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 259L, new DateTime(2022, 11, 18, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 264L, new DateTime(2022, 11, 18, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 269L, new DateTime(2022, 11, 18, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 379L, new DateTime(2022, 11, 21, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 374L, new DateTime(2022, 11, 21, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 369L, new DateTime(2022, 11, 21, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 364L, new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 359L, new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 354L, new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 349L, new DateTime(2022, 11, 20, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 344L, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 339L, new DateTime(2022, 11, 20, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 334L, new DateTime(2022, 11, 20, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 763L, new DateTime(2022, 12, 1, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 329L, new DateTime(2022, 11, 20, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 319L, new DateTime(2022, 11, 19, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 314L, new DateTime(2022, 11, 19, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 309L, new DateTime(2022, 11, 19, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 304L, new DateTime(2022, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 299L, new DateTime(2022, 11, 19, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 294L, new DateTime(2022, 11, 19, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 289L, new DateTime(2022, 11, 19, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 284L, new DateTime(2022, 11, 19, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 279L, new DateTime(2022, 11, 18, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 274L, new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 324L, new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 887L, new DateTime(2022, 12, 4, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 758L, new DateTime(2022, 11, 30, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 748L, new DateTime(2022, 11, 30, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 123L, new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 118L, new DateTime(2022, 11, 14, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 113L, new DateTime(2022, 11, 14, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 108L, new DateTime(2022, 11, 14, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 103L, new DateTime(2022, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 98L, new DateTime(2022, 11, 14, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 93L, new DateTime(2022, 11, 14, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 88L, new DateTime(2022, 11, 14, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 83L, new DateTime(2022, 11, 14, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 128L, new DateTime(2022, 11, 15, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 78L, new DateTime(2022, 11, 13, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 68L, new DateTime(2022, 11, 13, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 63L, new DateTime(2022, 11, 13, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 58L, new DateTime(2022, 11, 13, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 53L, new DateTime(2022, 11, 13, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 48L, new DateTime(2022, 11, 13, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 43L, new DateTime(2022, 11, 13, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 38L, new DateTime(2022, 11, 12, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 33L, new DateTime(2022, 11, 12, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 28L, new DateTime(2022, 11, 12, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 73L, new DateTime(2022, 11, 13, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 133L, new DateTime(2022, 11, 15, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 138L, new DateTime(2022, 11, 15, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 143L, new DateTime(2022, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 248L, new DateTime(2022, 11, 18, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 243L, new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 238L, new DateTime(2022, 11, 17, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 233L, new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 228L, new DateTime(2022, 11, 17, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 223L, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 218L, new DateTime(2022, 11, 17, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 213L, new DateTime(2022, 11, 17, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 208L, new DateTime(2022, 11, 17, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 203L, new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 198L, new DateTime(2022, 11, 16, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 193L, new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 188L, new DateTime(2022, 11, 16, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 183L, new DateTime(2022, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 178L, new DateTime(2022, 11, 16, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 173L, new DateTime(2022, 11, 16, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 168L, new DateTime(2022, 11, 16, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 163L, new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 158L, new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 153L, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 148L, new DateTime(2022, 11, 15, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 23L, new DateTime(2022, 11, 12, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 18L, new DateTime(2022, 11, 12, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 13L, new DateTime(2022, 11, 12, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 8L, new DateTime(2022, 11, 12, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 997L, new DateTime(2022, 12, 6, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 992L, new DateTime(2022, 12, 6, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 987L, new DateTime(2022, 12, 6, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 982L, new DateTime(2022, 12, 6, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 977L, new DateTime(2022, 12, 6, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 972L, new DateTime(2022, 12, 6, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 967L, new DateTime(2022, 12, 6, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 962L, new DateTime(2022, 12, 6, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 957L, new DateTime(2022, 12, 5, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 952L, new DateTime(2022, 12, 5, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 947L, new DateTime(2022, 12, 5, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 942L, new DateTime(2022, 12, 5, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 937L, new DateTime(2022, 12, 5, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 932L, new DateTime(2022, 12, 5, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 927L, new DateTime(2022, 12, 5, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 922L, new DateTime(2022, 12, 5, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 917L, new DateTime(2022, 12, 4, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 912L, new DateTime(2022, 12, 4, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 907L, new DateTime(2022, 12, 4, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 902L, new DateTime(2022, 12, 4, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 897L, new DateTime(2022, 12, 4, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 1002L, new DateTime(2022, 12, 7, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 753L, new DateTime(2022, 11, 30, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 1007L, new DateTime(2022, 12, 7, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 1017L, new DateTime(2022, 12, 7, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 3L, new DateTime(2022, 11, 12, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 1117L, new DateTime(2022, 12, 9, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 1112L, new DateTime(2022, 12, 9, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 1107L, new DateTime(2022, 12, 9, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 1102L, new DateTime(2022, 12, 9, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 1097L, new DateTime(2022, 12, 9, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 1092L, new DateTime(2022, 12, 9, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 1087L, new DateTime(2022, 12, 9, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 1082L, new DateTime(2022, 12, 9, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 1077L, new DateTime(2022, 12, 8, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 1072L, new DateTime(2022, 12, 8, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 1067L, new DateTime(2022, 12, 8, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 1062L, new DateTime(2022, 12, 8, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 1057L, new DateTime(2022, 12, 8, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 1052L, new DateTime(2022, 12, 8, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 1047L, new DateTime(2022, 12, 8, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 1042L, new DateTime(2022, 12, 8, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 1037L, new DateTime(2022, 12, 7, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 1032L, new DateTime(2022, 12, 7, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 1027L, new DateTime(2022, 12, 7, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 1022L, new DateTime(2022, 12, 7, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 1012L, new DateTime(2022, 12, 7, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 258L, new DateTime(2022, 11, 18, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 253L, new DateTime(2022, 11, 18, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 268L, new DateTime(2022, 11, 18, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 613L, new DateTime(2022, 11, 27, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 608L, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 603L, new DateTime(2022, 11, 27, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 598L, new DateTime(2022, 11, 26, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 593L, new DateTime(2022, 11, 26, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 588L, new DateTime(2022, 11, 26, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 583L, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 578L, new DateTime(2022, 11, 26, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 573L, new DateTime(2022, 11, 26, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 568L, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 563L, new DateTime(2022, 11, 26, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 558L, new DateTime(2022, 11, 25, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 553L, new DateTime(2022, 11, 25, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 548L, new DateTime(2022, 11, 25, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 543L, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 538L, new DateTime(2022, 11, 25, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 533L, new DateTime(2022, 11, 25, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 528L, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 523L, new DateTime(2022, 11, 25, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 518L, new DateTime(2022, 11, 24, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 513L, new DateTime(2022, 11, 24, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 618L, new DateTime(2022, 11, 27, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 623L, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 628L, new DateTime(2022, 11, 27, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 633L, new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 743L, new DateTime(2022, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 738L, new DateTime(2022, 11, 30, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 733L, new DateTime(2022, 11, 30, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 728L, new DateTime(2022, 11, 30, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 723L, new DateTime(2022, 11, 30, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 718L, new DateTime(2022, 11, 29, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 713L, new DateTime(2022, 11, 29, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 708L, new DateTime(2022, 11, 29, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 703L, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 698L, new DateTime(2022, 11, 29, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 508L, new DateTime(2022, 11, 24, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 693L, new DateTime(2022, 11, 29, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 683L, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 678L, new DateTime(2022, 11, 28, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 673L, new DateTime(2022, 11, 28, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 668L, new DateTime(2022, 11, 28, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 663L, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 658L, new DateTime(2022, 11, 28, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 653L, new DateTime(2022, 11, 28, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 648L, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 643L, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 638L, new DateTime(2022, 11, 27, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 688L, new DateTime(2022, 11, 29, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 263L, new DateTime(2022, 11, 18, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 503L, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 493L, new DateTime(2022, 11, 24, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 368L, new DateTime(2022, 11, 21, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 363L, new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 358L, new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 353L, new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 348L, new DateTime(2022, 11, 20, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 343L, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 338L, new DateTime(2022, 11, 20, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 333L, new DateTime(2022, 11, 20, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 328L, new DateTime(2022, 11, 20, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 498L, new DateTime(2022, 11, 24, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 323L, new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 313L, new DateTime(2022, 11, 19, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 308L, new DateTime(2022, 11, 19, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 303L, new DateTime(2022, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 298L, new DateTime(2022, 11, 19, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 293L, new DateTime(2022, 11, 19, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 288L, new DateTime(2022, 11, 19, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 283L, new DateTime(2022, 11, 19, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 278L, new DateTime(2022, 11, 18, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 273L, new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 318L, new DateTime(2022, 11, 19, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 378L, new DateTime(2022, 11, 21, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 373L, new DateTime(2022, 11, 21, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 388L, new DateTime(2022, 11, 21, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 488L, new DateTime(2022, 11, 24, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 483L, new DateTime(2022, 11, 24, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 478L, new DateTime(2022, 11, 23, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 473L, new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 468L, new DateTime(2022, 11, 23, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 463L, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 458L, new DateTime(2022, 11, 23, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 453L, new DateTime(2022, 11, 23, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 448L, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 443L, new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 438L, new DateTime(2022, 11, 22, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 433L, new DateTime(2022, 11, 22, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 428L, new DateTime(2022, 11, 22, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 423L, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 418L, new DateTime(2022, 11, 22, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 413L, new DateTime(2022, 11, 22, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 408L, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 403L, new DateTime(2022, 11, 22, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 398L, new DateTime(2022, 11, 21, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 393L, new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 383L, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 1L, new DateTime(2022, 11, 12, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "ProfileId", "RoleId", "UserName" },
                values: new object[,]
                {
                    { 1L, "admin@gmail.com", "admin", 1L, 1L, "admin" },
                    { 2L, "staff@gmail.com", "staff", 2L, 2L, "staff" },
                    { 3L, "user@gmail.com", "user", 3L, 3L, "user" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 289L, 63L, 188L },
                    { 200L, 33L, 17L },
                    { 79L, 33L, 32L },
                    { 68L, 33L, 77L },
                    { 35L, 33L, 12L },
                    { 8L, 33L, 82L },
                    { 292L, 32L, 57L },
                    { 293L, 33L, 57L },
                    { 199L, 32L, 17L },
                    { 6L, 31L, 82L },
                    { 277L, 29L, 191L },
                    { 33L, 29L, 131L },
                    { 247L, 28L, 86L },
                    { 246L, 27L, 86L },
                    { 245L, 26L, 86L },
                    { 7L, 32L, 82L },
                    { 36L, 34L, 12L },
                    { 69L, 34L, 77L },
                    { 201L, 34L, 17L },
                    { 104L, 38L, 147L },
                    { 18L, 38L, 87L },
                    { 282L, 37L, 32L },
                    { 204L, 37L, 67L },
                    { 76L, 37L, 142L },
                    { 17L, 37L, 87L },
                    { 203L, 36L, 67L },
                    { 97L, 36L, 187L },
                    { 75L, 36L, 142L },
                    { 27L, 36L, 152L },
                    { 202L, 35L, 17L },
                    { 74L, 35L, 142L },
                    { 26L, 35L, 152L },
                    { 294L, 34L, 57L },
                    { 231L, 34L, 112L },
                    { 96L, 26L, 36L },
                    { 95L, 25L, 36L },
                    { 269L, 24L, 196L },
                    { 197L, 24L, 91L },
                    { 23L, 13L, 106L },
                    { 112L, 12L, 11L },
                    { 85L, 12L, 16L },
                    { 22L, 12L, 106L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 111L, 11L, 11L },
                    { 84L, 11L, 16L },
                    { 73L, 11L, 141L },
                    { 72L, 10L, 141L },
                    { 128L, 9L, 131L },
                    { 127L, 8L, 131L },
                    { 126L, 7L, 131L },
                    { 12L, 7L, 1L },
                    { 189L, 6L, 191L },
                    { 11L, 6L, 1L },
                    { 188L, 5L, 191L },
                    { 173L, 14L, 151L },
                    { 283L, 38L, 32L },
                    { 198L, 14L, 36L },
                    { 77L, 16L, 76L },
                    { 268L, 23L, 196L },
                    { 196L, 23L, 91L },
                    { 267L, 22L, 196L },
                    { 195L, 22L, 91L },
                    { 194L, 21L, 91L },
                    { 208L, 18L, 136L },
                    { 115L, 18L, 191L },
                    { 2L, 18L, 151L },
                    { 298L, 17L, 36L },
                    { 207L, 17L, 136L },
                    { 114L, 17L, 191L },
                    { 78L, 17L, 76L },
                    { 1L, 17L, 151L },
                    { 297L, 16L, 36L },
                    { 113L, 16L, 191L },
                    { 174L, 15L, 151L },
                    { 159L, 5L, 116L },
                    { 299L, 38L, 77L },
                    { 149L, 39L, 2L },
                    { 183L, 278L, 69L },
                    { 182L, 277L, 69L },
                    { 87L, 275L, 179L },
                    { 86L, 274L, 179L },
                    { 258L, 141L, 168L },
                    { 236L, 141L, 193L },
                    { 240L, 279L, 59L },
                    { 257L, 140L, 168L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 256L, 139L, 168L },
                    { 61L, 60L, 82L },
                    { 45L, 59L, 47L },
                    { 106L, 58L, 112L },
                    { 44L, 58L, 47L },
                    { 218L, 57L, 62L },
                    { 235L, 140L, 193L },
                    { 241L, 280L, 59L },
                    { 242L, 281L, 59L },
                    { 135L, 285L, 149L },
                    { 132L, 473L, 115L },
                    { 131L, 472L, 115L },
                    { 216L, 306L, 149L },
                    { 191L, 306L, 154L },
                    { 138L, 306L, 144L },
                    { 215L, 305L, 149L },
                    { 137L, 305L, 144L },
                    { 214L, 304L, 149L },
                    { 172L, 304L, 124L },
                    { 171L, 303L, 124L },
                    { 108L, 301L, 124L },
                    { 107L, 300L, 124L },
                    { 285L, 299L, 164L },
                    { 284L, 298L, 164L },
                    { 136L, 286L, 149L },
                    { 217L, 56L, 62L },
                    { 206L, 56L, 102L },
                    { 252L, 55L, 167L },
                    { 205L, 55L, 102L },
                    { 219L, 46L, 152L },
                    { 153L, 44L, 112L },
                    { 57L, 44L, 97L },
                    { 152L, 43L, 112L },
                    { 110L, 43L, 42L },
                    { 56L, 43L, 97L },
                    { 187L, 42L, 132L },
                    { 163L, 42L, 122L },
                    { 109L, 42L, 42L },
                    { 55L, 42L, 97L },
                    { 186L, 41L, 132L },
                    { 162L, 41L, 122L },
                    { 54L, 41L, 97L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 185L, 40L, 132L },
                    { 300L, 39L, 77L },
                    { 13L, 47L, 57L },
                    { 105L, 39L, 147L },
                    { 70L, 47L, 102L },
                    { 14L, 48L, 57L },
                    { 142L, 55L, 157L },
                    { 251L, 54L, 167L },
                    { 141L, 54L, 157L },
                    { 157L, 53L, 17L },
                    { 32L, 53L, 2L },
                    { 156L, 52L, 17L },
                    { 31L, 52L, 2L },
                    { 151L, 51L, 107L },
                    { 30L, 51L, 2L },
                    { 21L, 51L, 112L },
                    { 150L, 50L, 107L },
                    { 20L, 50L, 112L },
                    { 19L, 49L, 112L },
                    { 281L, 48L, 122L },
                    { 71L, 48L, 102L },
                    { 220L, 47L, 152L },
                    { 239L, 4L, 76L },
                    { 210L, 4L, 176L },
                    { 165L, 4L, 181L },
                    { 90L, 154L, 114L },
                    { 234L, 147L, 4L },
                    { 67L, 147L, 114L },
                    { 233L, 146L, 4L },
                    { 43L, 146L, 49L },
                    { 232L, 145L, 4L },
                    { 91L, 155L, 114L },
                    { 143L, 145L, 159L },
                    { 260L, 138L, 53L },
                    { 259L, 137L, 53L },
                    { 276L, 132L, 23L },
                    { 275L, 131L, 23L },
                    { 274L, 130L, 23L },
                    { 122L, 130L, 88L },
                    { 42L, 145L, 49L },
                    { 92L, 156L, 114L },
                    { 295L, 157L, 144L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 296L, 158L, 144L },
                    { 167L, 187L, 74L },
                    { 166L, 186L, 74L },
                    { 225L, 185L, 24L },
                    { 10L, 185L, 144L },
                    { 224L, 184L, 24L },
                    { 9L, 184L, 144L },
                    { 223L, 183L, 24L },
                    { 148L, 174L, 94L },
                    { 147L, 173L, 94L },
                    { 177L, 172L, 139L },
                    { 146L, 172L, 94L },
                    { 176L, 171L, 139L },
                    { 175L, 170L, 139L },
                    { 244L, 162L, 129L },
                    { 243L, 161L, 129L },
                    { 273L, 129L, 23L },
                    { 140L, 129L, 148L },
                    { 139L, 128L, 148L },
                    { 181L, 123L, 83L },
                    { 170L, 77L, 128L },
                    { 169L, 76L, 128L },
                    { 60L, 71L, 103L },
                    { 264L, 70L, 188L },
                    { 179L, 70L, 78L },
                    { 59L, 70L, 103L },
                    { 38L, 70L, 33L },
                    { 263L, 69L, 188L },
                    { 178L, 69L, 78L },
                    { 161L, 69L, 68L },
                    { 58L, 69L, 103L },
                    { 37L, 69L, 33L },
                    { 160L, 68L, 68L },
                    { 291L, 65L, 188L },
                    { 290L, 64L, 188L },
                    { 118L, 78L, 188L },
                    { 168L, 188L, 74L },
                    { 119L, 79L, 188L },
                    { 101L, 88L, 188L },
                    { 180L, 122L, 83L },
                    { 145L, 122L, 33L },
                    { 144L, 121L, 33L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 89L, 119L, 133L },
                    { 125L, 118L, 193L },
                    { 88L, 118L, 133L },
                    { 124L, 117L, 193L },
                    { 123L, 116L, 193L },
                    { 278L, 114L, 93L },
                    { 190L, 111L, 138L },
                    { 238L, 91L, 3L },
                    { 237L, 90L, 3L },
                    { 103L, 90L, 188L },
                    { 184L, 89L, 128L },
                    { 102L, 89L, 188L },
                    { 51L, 85L, 123L },
                    { 4L, 210L, 34L },
                    { 5L, 211L, 34L },
                    { 48L, 220L, 174L },
                    { 192L, 416L, 80L },
                    { 280L, 414L, 45L },
                    { 279L, 413L, 45L },
                    { 222L, 411L, 135L },
                    { 221L, 410L, 135L },
                    { 121L, 410L, 20L },
                    { 120L, 409L, 20L },
                    { 83L, 402L, 25L },
                    { 82L, 401L, 25L },
                    { 117L, 396L, 55L },
                    { 116L, 395L, 55L },
                    { 262L, 393L, 150L },
                    { 261L, 392L, 150L },
                    { 265L, 389L, 130L },
                    { 47L, 388L, 30L },
                    { 193L, 417L, 80L },
                    { 41L, 379L, 100L },
                    { 229L, 418L, 80L },
                    { 80L, 429L, 5L },
                    { 158L, 4L, 116L },
                    { 66L, 4L, 11L },
                    { 209L, 3L, 176L },
                    { 164L, 3L, 181L },
                    { 65L, 3L, 11L },
                    { 266L, 2L, 81L },
                    { 64L, 2L, 11L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 63L, 1L, 11L },
                    { 16L, 461L, 130L },
                    { 15L, 460L, 130L },
                    { 272L, 436L, 15L },
                    { 271L, 435L, 15L },
                    { 270L, 434L, 15L },
                    { 46L, 431L, 40L },
                    { 81L, 430L, 5L },
                    { 230L, 419L, 80L },
                    { 133L, 474L, 115L },
                    { 40L, 378L, 100L },
                    { 39L, 377L, 100L },
                    { 288L, 245L, 39L },
                    { 250L, 245L, 79L },
                    { 287L, 244L, 39L },
                    { 249L, 244L, 79L },
                    { 286L, 243L, 39L },
                    { 248L, 243L, 79L },
                    { 255L, 235L, 134L },
                    { 254L, 234L, 134L },
                    { 253L, 233L, 134L },
                    { 130L, 233L, 194L },
                    { 129L, 232L, 194L },
                    { 94L, 228L, 134L },
                    { 93L, 227L, 134L },
                    { 50L, 222L, 174L },
                    { 49L, 221L, 174L },
                    { 28L, 309L, 35L },
                    { 62L, 377L, 45L },
                    { 52L, 309L, 15L },
                    { 53L, 310L, 15L },
                    { 25L, 351L, 10L },
                    { 24L, 350L, 10L },
                    { 99L, 341L, 70L },
                    { 98L, 340L, 70L },
                    { 3L, 339L, 70L },
                    { 34L, 336L, 160L },
                    { 155L, 334L, 50L },
                    { 154L, 333L, 50L },
                    { 213L, 325L, 145L },
                    { 212L, 324L, 145L },
                    { 211L, 323L, 145L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 228L, 316L, 110L },
                    { 227L, 315L, 110L },
                    { 226L, 314L, 110L },
                    { 100L, 312L, 65L },
                    { 29L, 310L, 35L },
                    { 134L, 475L, 115L }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Profile_ProfileId",
                table: "Users",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
