using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CINEMATRIX.Data.EF.SQL.Migrations
{
    public partial class ApplyDataConfigurationsSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieName",
                table: "Sessions");

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 10, 3, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 738L, new DateTime(2022, 10, 21, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 739L, new DateTime(2022, 10, 21, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 740L, new DateTime(2022, 10, 21, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 741L, new DateTime(2022, 10, 21, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 742L, new DateTime(2022, 10, 21, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 743L, new DateTime(2022, 10, 21, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 744L, new DateTime(2022, 10, 21, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 745L, new DateTime(2022, 10, 21, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 746L, new DateTime(2022, 10, 21, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 747L, new DateTime(2022, 10, 21, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 748L, new DateTime(2022, 10, 21, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 749L, new DateTime(2022, 10, 21, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 750L, new DateTime(2022, 10, 21, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 751L, new DateTime(2022, 10, 21, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 752L, new DateTime(2022, 10, 21, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 753L, new DateTime(2022, 10, 21, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 754L, new DateTime(2022, 10, 21, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 768L, new DateTime(2022, 10, 22, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 767L, new DateTime(2022, 10, 22, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 766L, new DateTime(2022, 10, 22, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 765L, new DateTime(2022, 10, 22, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 764L, new DateTime(2022, 10, 22, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 763L, new DateTime(2022, 10, 22, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 737L, new DateTime(2022, 10, 21, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 762L, new DateTime(2022, 10, 22, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 760L, new DateTime(2022, 10, 21, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 759L, new DateTime(2022, 10, 21, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 758L, new DateTime(2022, 10, 21, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 757L, new DateTime(2022, 10, 21, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 756L, new DateTime(2022, 10, 21, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 755L, new DateTime(2022, 10, 21, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 761L, new DateTime(2022, 10, 22, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 769L, new DateTime(2022, 10, 22, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 736L, new DateTime(2022, 10, 21, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 734L, new DateTime(2022, 10, 21, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 703L, new DateTime(2022, 10, 20, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 704L, new DateTime(2022, 10, 20, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 705L, new DateTime(2022, 10, 20, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 706L, new DateTime(2022, 10, 20, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 707L, new DateTime(2022, 10, 20, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 708L, new DateTime(2022, 10, 20, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 709L, new DateTime(2022, 10, 20, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 710L, new DateTime(2022, 10, 20, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 711L, new DateTime(2022, 10, 20, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 712L, new DateTime(2022, 10, 20, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 713L, new DateTime(2022, 10, 20, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 714L, new DateTime(2022, 10, 20, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 715L, new DateTime(2022, 10, 20, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 716L, new DateTime(2022, 10, 20, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 717L, new DateTime(2022, 10, 20, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 718L, new DateTime(2022, 10, 20, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 719L, new DateTime(2022, 10, 20, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 733L, new DateTime(2022, 10, 21, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 732L, new DateTime(2022, 10, 21, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 731L, new DateTime(2022, 10, 21, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 730L, new DateTime(2022, 10, 21, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 729L, new DateTime(2022, 10, 21, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 728L, new DateTime(2022, 10, 21, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 735L, new DateTime(2022, 10, 21, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 727L, new DateTime(2022, 10, 21, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 725L, new DateTime(2022, 10, 21, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 724L, new DateTime(2022, 10, 21, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 723L, new DateTime(2022, 10, 21, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 722L, new DateTime(2022, 10, 21, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 721L, new DateTime(2022, 10, 21, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 720L, new DateTime(2022, 10, 20, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 726L, new DateTime(2022, 10, 21, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 702L, new DateTime(2022, 10, 20, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 770L, new DateTime(2022, 10, 22, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 772L, new DateTime(2022, 10, 22, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 808L, new DateTime(2022, 10, 23, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 809L, new DateTime(2022, 10, 23, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 810L, new DateTime(2022, 10, 23, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 811L, new DateTime(2022, 10, 23, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 812L, new DateTime(2022, 10, 23, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 813L, new DateTime(2022, 10, 23, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 814L, new DateTime(2022, 10, 23, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 815L, new DateTime(2022, 10, 23, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 816L, new DateTime(2022, 10, 23, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 817L, new DateTime(2022, 10, 23, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 818L, new DateTime(2022, 10, 23, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 819L, new DateTime(2022, 10, 23, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 820L, new DateTime(2022, 10, 23, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 821L, new DateTime(2022, 10, 23, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 822L, new DateTime(2022, 10, 23, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 823L, new DateTime(2022, 10, 23, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 824L, new DateTime(2022, 10, 23, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 838L, new DateTime(2022, 10, 23, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 837L, new DateTime(2022, 10, 23, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 836L, new DateTime(2022, 10, 23, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 835L, new DateTime(2022, 10, 23, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 834L, new DateTime(2022, 10, 23, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 833L, new DateTime(2022, 10, 23, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 807L, new DateTime(2022, 10, 23, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 832L, new DateTime(2022, 10, 23, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 830L, new DateTime(2022, 10, 23, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 829L, new DateTime(2022, 10, 23, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 828L, new DateTime(2022, 10, 23, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 827L, new DateTime(2022, 10, 23, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 826L, new DateTime(2022, 10, 23, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 825L, new DateTime(2022, 10, 23, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 831L, new DateTime(2022, 10, 23, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 771L, new DateTime(2022, 10, 22, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 806L, new DateTime(2022, 10, 23, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 804L, new DateTime(2022, 10, 23, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 773L, new DateTime(2022, 10, 22, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 774L, new DateTime(2022, 10, 22, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 775L, new DateTime(2022, 10, 22, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 776L, new DateTime(2022, 10, 22, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 777L, new DateTime(2022, 10, 22, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 778L, new DateTime(2022, 10, 22, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 779L, new DateTime(2022, 10, 22, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 780L, new DateTime(2022, 10, 22, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 781L, new DateTime(2022, 10, 22, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 782L, new DateTime(2022, 10, 22, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 783L, new DateTime(2022, 10, 22, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 784L, new DateTime(2022, 10, 22, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 785L, new DateTime(2022, 10, 22, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 786L, new DateTime(2022, 10, 22, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 787L, new DateTime(2022, 10, 22, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 788L, new DateTime(2022, 10, 22, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 789L, new DateTime(2022, 10, 22, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 803L, new DateTime(2022, 10, 23, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 802L, new DateTime(2022, 10, 23, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 801L, new DateTime(2022, 10, 23, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 800L, new DateTime(2022, 10, 22, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 799L, new DateTime(2022, 10, 22, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 798L, new DateTime(2022, 10, 22, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 805L, new DateTime(2022, 10, 23, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 797L, new DateTime(2022, 10, 22, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 795L, new DateTime(2022, 10, 22, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 794L, new DateTime(2022, 10, 22, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 793L, new DateTime(2022, 10, 22, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 792L, new DateTime(2022, 10, 22, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 791L, new DateTime(2022, 10, 22, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 790L, new DateTime(2022, 10, 22, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 796L, new DateTime(2022, 10, 22, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 839L, new DateTime(2022, 10, 23, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 701L, new DateTime(2022, 10, 20, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 699L, new DateTime(2022, 10, 20, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 598L, new DateTime(2022, 10, 17, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 599L, new DateTime(2022, 10, 17, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 600L, new DateTime(2022, 10, 17, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 601L, new DateTime(2022, 10, 18, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 602L, new DateTime(2022, 10, 18, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 603L, new DateTime(2022, 10, 18, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 604L, new DateTime(2022, 10, 18, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 605L, new DateTime(2022, 10, 18, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 606L, new DateTime(2022, 10, 18, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 607L, new DateTime(2022, 10, 18, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 608L, new DateTime(2022, 10, 18, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 609L, new DateTime(2022, 10, 18, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 610L, new DateTime(2022, 10, 18, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 611L, new DateTime(2022, 10, 18, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 612L, new DateTime(2022, 10, 18, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 613L, new DateTime(2022, 10, 18, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 614L, new DateTime(2022, 10, 18, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 628L, new DateTime(2022, 10, 18, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 627L, new DateTime(2022, 10, 18, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 626L, new DateTime(2022, 10, 18, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 625L, new DateTime(2022, 10, 18, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 624L, new DateTime(2022, 10, 18, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 623L, new DateTime(2022, 10, 18, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 597L, new DateTime(2022, 10, 17, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 622L, new DateTime(2022, 10, 18, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 620L, new DateTime(2022, 10, 18, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 619L, new DateTime(2022, 10, 18, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 618L, new DateTime(2022, 10, 18, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 617L, new DateTime(2022, 10, 18, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 616L, new DateTime(2022, 10, 18, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 615L, new DateTime(2022, 10, 18, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 621L, new DateTime(2022, 10, 18, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 629L, new DateTime(2022, 10, 18, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 596L, new DateTime(2022, 10, 17, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 594L, new DateTime(2022, 10, 17, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 563L, new DateTime(2022, 10, 17, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 564L, new DateTime(2022, 10, 17, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 565L, new DateTime(2022, 10, 17, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 566L, new DateTime(2022, 10, 17, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 567L, new DateTime(2022, 10, 17, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 568L, new DateTime(2022, 10, 17, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 569L, new DateTime(2022, 10, 17, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 570L, new DateTime(2022, 10, 17, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 571L, new DateTime(2022, 10, 17, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 572L, new DateTime(2022, 10, 17, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 573L, new DateTime(2022, 10, 17, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 574L, new DateTime(2022, 10, 17, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 575L, new DateTime(2022, 10, 17, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 576L, new DateTime(2022, 10, 17, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 577L, new DateTime(2022, 10, 17, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 578L, new DateTime(2022, 10, 17, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 579L, new DateTime(2022, 10, 17, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 593L, new DateTime(2022, 10, 17, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 592L, new DateTime(2022, 10, 17, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 591L, new DateTime(2022, 10, 17, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 590L, new DateTime(2022, 10, 17, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 589L, new DateTime(2022, 10, 17, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 588L, new DateTime(2022, 10, 17, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 595L, new DateTime(2022, 10, 17, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 587L, new DateTime(2022, 10, 17, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 585L, new DateTime(2022, 10, 17, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 584L, new DateTime(2022, 10, 17, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 583L, new DateTime(2022, 10, 17, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 582L, new DateTime(2022, 10, 17, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 581L, new DateTime(2022, 10, 17, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 580L, new DateTime(2022, 10, 17, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 586L, new DateTime(2022, 10, 17, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 700L, new DateTime(2022, 10, 20, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 630L, new DateTime(2022, 10, 18, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 632L, new DateTime(2022, 10, 18, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 668L, new DateTime(2022, 10, 19, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 669L, new DateTime(2022, 10, 19, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 670L, new DateTime(2022, 10, 19, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 671L, new DateTime(2022, 10, 19, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 672L, new DateTime(2022, 10, 19, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 673L, new DateTime(2022, 10, 19, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 674L, new DateTime(2022, 10, 19, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 675L, new DateTime(2022, 10, 19, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 676L, new DateTime(2022, 10, 19, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 677L, new DateTime(2022, 10, 19, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 678L, new DateTime(2022, 10, 19, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 679L, new DateTime(2022, 10, 19, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 680L, new DateTime(2022, 10, 19, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 681L, new DateTime(2022, 10, 20, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 682L, new DateTime(2022, 10, 20, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 683L, new DateTime(2022, 10, 20, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 684L, new DateTime(2022, 10, 20, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 698L, new DateTime(2022, 10, 20, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 697L, new DateTime(2022, 10, 20, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 696L, new DateTime(2022, 10, 20, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 695L, new DateTime(2022, 10, 20, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 694L, new DateTime(2022, 10, 20, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 693L, new DateTime(2022, 10, 20, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 667L, new DateTime(2022, 10, 19, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 692L, new DateTime(2022, 10, 20, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 690L, new DateTime(2022, 10, 20, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 689L, new DateTime(2022, 10, 20, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 688L, new DateTime(2022, 10, 20, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 687L, new DateTime(2022, 10, 20, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 686L, new DateTime(2022, 10, 20, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 685L, new DateTime(2022, 10, 20, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 691L, new DateTime(2022, 10, 20, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 631L, new DateTime(2022, 10, 18, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 666L, new DateTime(2022, 10, 19, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 664L, new DateTime(2022, 10, 19, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 633L, new DateTime(2022, 10, 18, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 634L, new DateTime(2022, 10, 18, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 635L, new DateTime(2022, 10, 18, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 636L, new DateTime(2022, 10, 18, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 637L, new DateTime(2022, 10, 18, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 638L, new DateTime(2022, 10, 18, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 639L, new DateTime(2022, 10, 18, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 640L, new DateTime(2022, 10, 18, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 641L, new DateTime(2022, 10, 19, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 642L, new DateTime(2022, 10, 19, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 643L, new DateTime(2022, 10, 19, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 644L, new DateTime(2022, 10, 19, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 645L, new DateTime(2022, 10, 19, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 646L, new DateTime(2022, 10, 19, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 647L, new DateTime(2022, 10, 19, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 648L, new DateTime(2022, 10, 19, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 649L, new DateTime(2022, 10, 19, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 663L, new DateTime(2022, 10, 19, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 662L, new DateTime(2022, 10, 19, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 661L, new DateTime(2022, 10, 19, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 660L, new DateTime(2022, 10, 19, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 659L, new DateTime(2022, 10, 19, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 658L, new DateTime(2022, 10, 19, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 665L, new DateTime(2022, 10, 19, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 657L, new DateTime(2022, 10, 19, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 655L, new DateTime(2022, 10, 19, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 654L, new DateTime(2022, 10, 19, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 653L, new DateTime(2022, 10, 19, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 652L, new DateTime(2022, 10, 19, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 651L, new DateTime(2022, 10, 19, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 650L, new DateTime(2022, 10, 19, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 656L, new DateTime(2022, 10, 19, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 562L, new DateTime(2022, 10, 17, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 840L, new DateTime(2022, 10, 23, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 842L, new DateTime(2022, 10, 24, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 1018L, new DateTime(2022, 10, 28, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 1019L, new DateTime(2022, 10, 28, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 1020L, new DateTime(2022, 10, 28, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 1021L, new DateTime(2022, 10, 28, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 1022L, new DateTime(2022, 10, 28, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 1023L, new DateTime(2022, 10, 28, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 1024L, new DateTime(2022, 10, 28, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 1025L, new DateTime(2022, 10, 28, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 1026L, new DateTime(2022, 10, 28, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 1027L, new DateTime(2022, 10, 28, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 1028L, new DateTime(2022, 10, 28, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 1029L, new DateTime(2022, 10, 28, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 1030L, new DateTime(2022, 10, 28, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 1031L, new DateTime(2022, 10, 28, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 1032L, new DateTime(2022, 10, 28, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 1033L, new DateTime(2022, 10, 28, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 1034L, new DateTime(2022, 10, 28, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 1048L, new DateTime(2022, 10, 29, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 1047L, new DateTime(2022, 10, 29, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 1046L, new DateTime(2022, 10, 29, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 1045L, new DateTime(2022, 10, 29, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 1044L, new DateTime(2022, 10, 29, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 1043L, new DateTime(2022, 10, 29, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 1017L, new DateTime(2022, 10, 28, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 1042L, new DateTime(2022, 10, 29, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 1040L, new DateTime(2022, 10, 28, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 1039L, new DateTime(2022, 10, 28, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 1038L, new DateTime(2022, 10, 28, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 1037L, new DateTime(2022, 10, 28, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 1036L, new DateTime(2022, 10, 28, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 1035L, new DateTime(2022, 10, 28, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 1041L, new DateTime(2022, 10, 29, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 1049L, new DateTime(2022, 10, 29, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 1016L, new DateTime(2022, 10, 28, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 1014L, new DateTime(2022, 10, 28, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 983L, new DateTime(2022, 10, 27, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 984L, new DateTime(2022, 10, 27, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 985L, new DateTime(2022, 10, 27, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 986L, new DateTime(2022, 10, 27, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 987L, new DateTime(2022, 10, 27, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 988L, new DateTime(2022, 10, 27, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 989L, new DateTime(2022, 10, 27, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 990L, new DateTime(2022, 10, 27, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 991L, new DateTime(2022, 10, 27, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 992L, new DateTime(2022, 10, 27, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 993L, new DateTime(2022, 10, 27, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 994L, new DateTime(2022, 10, 27, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 995L, new DateTime(2022, 10, 27, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 996L, new DateTime(2022, 10, 27, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 997L, new DateTime(2022, 10, 27, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 998L, new DateTime(2022, 10, 27, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 999L, new DateTime(2022, 10, 27, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 1013L, new DateTime(2022, 10, 28, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 1012L, new DateTime(2022, 10, 28, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 1011L, new DateTime(2022, 10, 28, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 1010L, new DateTime(2022, 10, 28, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 1009L, new DateTime(2022, 10, 28, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 1008L, new DateTime(2022, 10, 28, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 1015L, new DateTime(2022, 10, 28, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 1007L, new DateTime(2022, 10, 28, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 1005L, new DateTime(2022, 10, 28, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 1004L, new DateTime(2022, 10, 28, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 1003L, new DateTime(2022, 10, 28, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 1002L, new DateTime(2022, 10, 28, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 1001L, new DateTime(2022, 10, 28, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 1000L, new DateTime(2022, 10, 27, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 1006L, new DateTime(2022, 10, 28, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 982L, new DateTime(2022, 10, 27, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 1050L, new DateTime(2022, 10, 29, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 1052L, new DateTime(2022, 10, 29, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 1088L, new DateTime(2022, 10, 30, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 1089L, new DateTime(2022, 10, 30, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 1090L, new DateTime(2022, 10, 30, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 1091L, new DateTime(2022, 10, 30, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 1092L, new DateTime(2022, 10, 30, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 1093L, new DateTime(2022, 10, 30, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 1094L, new DateTime(2022, 10, 30, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 1095L, new DateTime(2022, 10, 30, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 1096L, new DateTime(2022, 10, 30, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 1097L, new DateTime(2022, 10, 30, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 1098L, new DateTime(2022, 10, 30, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 1099L, new DateTime(2022, 10, 30, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 1100L, new DateTime(2022, 10, 30, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 1101L, new DateTime(2022, 10, 30, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 1102L, new DateTime(2022, 10, 30, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 1103L, new DateTime(2022, 10, 30, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 1104L, new DateTime(2022, 10, 30, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 1118L, new DateTime(2022, 10, 30, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 1117L, new DateTime(2022, 10, 30, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 1116L, new DateTime(2022, 10, 30, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 1115L, new DateTime(2022, 10, 30, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 1114L, new DateTime(2022, 10, 30, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 1113L, new DateTime(2022, 10, 30, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 1087L, new DateTime(2022, 10, 30, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 1112L, new DateTime(2022, 10, 30, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 1110L, new DateTime(2022, 10, 30, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 1109L, new DateTime(2022, 10, 30, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 1108L, new DateTime(2022, 10, 30, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 1107L, new DateTime(2022, 10, 30, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 1106L, new DateTime(2022, 10, 30, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 1105L, new DateTime(2022, 10, 30, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 1111L, new DateTime(2022, 10, 30, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 1051L, new DateTime(2022, 10, 29, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 1086L, new DateTime(2022, 10, 30, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 1084L, new DateTime(2022, 10, 30, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 1053L, new DateTime(2022, 10, 29, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 1054L, new DateTime(2022, 10, 29, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 1055L, new DateTime(2022, 10, 29, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 1056L, new DateTime(2022, 10, 29, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 1057L, new DateTime(2022, 10, 29, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 1058L, new DateTime(2022, 10, 29, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 1059L, new DateTime(2022, 10, 29, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 1060L, new DateTime(2022, 10, 29, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 1061L, new DateTime(2022, 10, 29, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 1062L, new DateTime(2022, 10, 29, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 1063L, new DateTime(2022, 10, 29, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 1064L, new DateTime(2022, 10, 29, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 1065L, new DateTime(2022, 10, 29, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 1066L, new DateTime(2022, 10, 29, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 1067L, new DateTime(2022, 10, 29, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 1068L, new DateTime(2022, 10, 29, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 1069L, new DateTime(2022, 10, 29, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 1083L, new DateTime(2022, 10, 30, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 1082L, new DateTime(2022, 10, 30, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 1081L, new DateTime(2022, 10, 30, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 1080L, new DateTime(2022, 10, 29, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 1079L, new DateTime(2022, 10, 29, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 1078L, new DateTime(2022, 10, 29, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 1085L, new DateTime(2022, 10, 30, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 1077L, new DateTime(2022, 10, 29, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 1075L, new DateTime(2022, 10, 29, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 1074L, new DateTime(2022, 10, 29, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 1073L, new DateTime(2022, 10, 29, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 1072L, new DateTime(2022, 10, 29, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 1071L, new DateTime(2022, 10, 29, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 1070L, new DateTime(2022, 10, 29, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 1076L, new DateTime(2022, 10, 29, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 841L, new DateTime(2022, 10, 24, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 981L, new DateTime(2022, 10, 27, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 979L, new DateTime(2022, 10, 27, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 878L, new DateTime(2022, 10, 24, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 879L, new DateTime(2022, 10, 24, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 880L, new DateTime(2022, 10, 24, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 881L, new DateTime(2022, 10, 25, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 882L, new DateTime(2022, 10, 25, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 883L, new DateTime(2022, 10, 25, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 884L, new DateTime(2022, 10, 25, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 885L, new DateTime(2022, 10, 25, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 886L, new DateTime(2022, 10, 25, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 887L, new DateTime(2022, 10, 25, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 888L, new DateTime(2022, 10, 25, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 889L, new DateTime(2022, 10, 25, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 890L, new DateTime(2022, 10, 25, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 891L, new DateTime(2022, 10, 25, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 892L, new DateTime(2022, 10, 25, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 893L, new DateTime(2022, 10, 25, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 894L, new DateTime(2022, 10, 25, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 908L, new DateTime(2022, 10, 25, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 907L, new DateTime(2022, 10, 25, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 906L, new DateTime(2022, 10, 25, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 905L, new DateTime(2022, 10, 25, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 904L, new DateTime(2022, 10, 25, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 903L, new DateTime(2022, 10, 25, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 877L, new DateTime(2022, 10, 24, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 902L, new DateTime(2022, 10, 25, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 900L, new DateTime(2022, 10, 25, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 899L, new DateTime(2022, 10, 25, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 898L, new DateTime(2022, 10, 25, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 897L, new DateTime(2022, 10, 25, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 896L, new DateTime(2022, 10, 25, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 895L, new DateTime(2022, 10, 25, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 901L, new DateTime(2022, 10, 25, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 909L, new DateTime(2022, 10, 25, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 876L, new DateTime(2022, 10, 24, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 874L, new DateTime(2022, 10, 24, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 843L, new DateTime(2022, 10, 24, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 844L, new DateTime(2022, 10, 24, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 845L, new DateTime(2022, 10, 24, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 846L, new DateTime(2022, 10, 24, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 847L, new DateTime(2022, 10, 24, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 848L, new DateTime(2022, 10, 24, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 849L, new DateTime(2022, 10, 24, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 850L, new DateTime(2022, 10, 24, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 851L, new DateTime(2022, 10, 24, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 852L, new DateTime(2022, 10, 24, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 853L, new DateTime(2022, 10, 24, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 854L, new DateTime(2022, 10, 24, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 855L, new DateTime(2022, 10, 24, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 856L, new DateTime(2022, 10, 24, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 857L, new DateTime(2022, 10, 24, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 858L, new DateTime(2022, 10, 24, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 859L, new DateTime(2022, 10, 24, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 873L, new DateTime(2022, 10, 24, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 872L, new DateTime(2022, 10, 24, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 871L, new DateTime(2022, 10, 24, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 870L, new DateTime(2022, 10, 24, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 869L, new DateTime(2022, 10, 24, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 868L, new DateTime(2022, 10, 24, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 875L, new DateTime(2022, 10, 24, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 867L, new DateTime(2022, 10, 24, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 865L, new DateTime(2022, 10, 24, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 864L, new DateTime(2022, 10, 24, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 863L, new DateTime(2022, 10, 24, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 862L, new DateTime(2022, 10, 24, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 861L, new DateTime(2022, 10, 24, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 860L, new DateTime(2022, 10, 24, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 866L, new DateTime(2022, 10, 24, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 980L, new DateTime(2022, 10, 27, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 910L, new DateTime(2022, 10, 25, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 912L, new DateTime(2022, 10, 25, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 948L, new DateTime(2022, 10, 26, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 949L, new DateTime(2022, 10, 26, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 950L, new DateTime(2022, 10, 26, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 951L, new DateTime(2022, 10, 26, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 952L, new DateTime(2022, 10, 26, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 953L, new DateTime(2022, 10, 26, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 954L, new DateTime(2022, 10, 26, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 955L, new DateTime(2022, 10, 26, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 956L, new DateTime(2022, 10, 26, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 957L, new DateTime(2022, 10, 26, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 958L, new DateTime(2022, 10, 26, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 959L, new DateTime(2022, 10, 26, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 960L, new DateTime(2022, 10, 26, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 961L, new DateTime(2022, 10, 27, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 962L, new DateTime(2022, 10, 27, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 963L, new DateTime(2022, 10, 27, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 964L, new DateTime(2022, 10, 27, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 978L, new DateTime(2022, 10, 27, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 977L, new DateTime(2022, 10, 27, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 976L, new DateTime(2022, 10, 27, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 975L, new DateTime(2022, 10, 27, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 974L, new DateTime(2022, 10, 27, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 973L, new DateTime(2022, 10, 27, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 947L, new DateTime(2022, 10, 26, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 972L, new DateTime(2022, 10, 27, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 970L, new DateTime(2022, 10, 27, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 969L, new DateTime(2022, 10, 27, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 968L, new DateTime(2022, 10, 27, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 967L, new DateTime(2022, 10, 27, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 966L, new DateTime(2022, 10, 27, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 965L, new DateTime(2022, 10, 27, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 971L, new DateTime(2022, 10, 27, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 911L, new DateTime(2022, 10, 25, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 946L, new DateTime(2022, 10, 26, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 944L, new DateTime(2022, 10, 26, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 913L, new DateTime(2022, 10, 25, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 914L, new DateTime(2022, 10, 25, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 915L, new DateTime(2022, 10, 25, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 916L, new DateTime(2022, 10, 25, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 917L, new DateTime(2022, 10, 25, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 918L, new DateTime(2022, 10, 25, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 919L, new DateTime(2022, 10, 25, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 920L, new DateTime(2022, 10, 25, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 921L, new DateTime(2022, 10, 26, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 922L, new DateTime(2022, 10, 26, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 923L, new DateTime(2022, 10, 26, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 924L, new DateTime(2022, 10, 26, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 925L, new DateTime(2022, 10, 26, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 926L, new DateTime(2022, 10, 26, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 927L, new DateTime(2022, 10, 26, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 928L, new DateTime(2022, 10, 26, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 929L, new DateTime(2022, 10, 26, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 943L, new DateTime(2022, 10, 26, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 942L, new DateTime(2022, 10, 26, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 941L, new DateTime(2022, 10, 26, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 940L, new DateTime(2022, 10, 26, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 939L, new DateTime(2022, 10, 26, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 938L, new DateTime(2022, 10, 26, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 945L, new DateTime(2022, 10, 26, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 937L, new DateTime(2022, 10, 26, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 935L, new DateTime(2022, 10, 26, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 934L, new DateTime(2022, 10, 26, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 933L, new DateTime(2022, 10, 26, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 932L, new DateTime(2022, 10, 26, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 931L, new DateTime(2022, 10, 26, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 930L, new DateTime(2022, 10, 26, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 936L, new DateTime(2022, 10, 26, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 561L, new DateTime(2022, 10, 17, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 560L, new DateTime(2022, 10, 16, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 559L, new DateTime(2022, 10, 16, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 177L, new DateTime(2022, 10, 7, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 178L, new DateTime(2022, 10, 7, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 179L, new DateTime(2022, 10, 7, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 180L, new DateTime(2022, 10, 7, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 181L, new DateTime(2022, 10, 7, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 182L, new DateTime(2022, 10, 7, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 183L, new DateTime(2022, 10, 7, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 184L, new DateTime(2022, 10, 7, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 185L, new DateTime(2022, 10, 7, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 186L, new DateTime(2022, 10, 7, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 187L, new DateTime(2022, 10, 7, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 188L, new DateTime(2022, 10, 7, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 189L, new DateTime(2022, 10, 7, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 190L, new DateTime(2022, 10, 7, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 191L, new DateTime(2022, 10, 7, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 192L, new DateTime(2022, 10, 7, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 193L, new DateTime(2022, 10, 7, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 207L, new DateTime(2022, 10, 8, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 206L, new DateTime(2022, 10, 8, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 205L, new DateTime(2022, 10, 8, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 204L, new DateTime(2022, 10, 8, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 203L, new DateTime(2022, 10, 8, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 202L, new DateTime(2022, 10, 8, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 176L, new DateTime(2022, 10, 7, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 201L, new DateTime(2022, 10, 8, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 199L, new DateTime(2022, 10, 7, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 198L, new DateTime(2022, 10, 7, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 197L, new DateTime(2022, 10, 7, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 196L, new DateTime(2022, 10, 7, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 195L, new DateTime(2022, 10, 7, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 194L, new DateTime(2022, 10, 7, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 200L, new DateTime(2022, 10, 7, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 208L, new DateTime(2022, 10, 8, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 175L, new DateTime(2022, 10, 7, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 173L, new DateTime(2022, 10, 7, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 142L, new DateTime(2022, 10, 6, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 143L, new DateTime(2022, 10, 6, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 144L, new DateTime(2022, 10, 6, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 145L, new DateTime(2022, 10, 6, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 146L, new DateTime(2022, 10, 6, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 147L, new DateTime(2022, 10, 6, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 148L, new DateTime(2022, 10, 6, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 149L, new DateTime(2022, 10, 6, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 150L, new DateTime(2022, 10, 6, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 151L, new DateTime(2022, 10, 6, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 152L, new DateTime(2022, 10, 6, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 153L, new DateTime(2022, 10, 6, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 154L, new DateTime(2022, 10, 6, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 155L, new DateTime(2022, 10, 6, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 156L, new DateTime(2022, 10, 6, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 157L, new DateTime(2022, 10, 6, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 158L, new DateTime(2022, 10, 6, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 172L, new DateTime(2022, 10, 7, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 171L, new DateTime(2022, 10, 7, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 170L, new DateTime(2022, 10, 7, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 169L, new DateTime(2022, 10, 7, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 168L, new DateTime(2022, 10, 7, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 167L, new DateTime(2022, 10, 7, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 174L, new DateTime(2022, 10, 7, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 166L, new DateTime(2022, 10, 7, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 164L, new DateTime(2022, 10, 7, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 163L, new DateTime(2022, 10, 7, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 162L, new DateTime(2022, 10, 7, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 161L, new DateTime(2022, 10, 7, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 160L, new DateTime(2022, 10, 6, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 159L, new DateTime(2022, 10, 6, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 165L, new DateTime(2022, 10, 7, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 141L, new DateTime(2022, 10, 6, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 209L, new DateTime(2022, 10, 8, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 211L, new DateTime(2022, 10, 8, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 247L, new DateTime(2022, 10, 9, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 248L, new DateTime(2022, 10, 9, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 249L, new DateTime(2022, 10, 9, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 250L, new DateTime(2022, 10, 9, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 251L, new DateTime(2022, 10, 9, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 252L, new DateTime(2022, 10, 9, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 253L, new DateTime(2022, 10, 9, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 254L, new DateTime(2022, 10, 9, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 255L, new DateTime(2022, 10, 9, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 256L, new DateTime(2022, 10, 9, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 257L, new DateTime(2022, 10, 9, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 258L, new DateTime(2022, 10, 9, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 259L, new DateTime(2022, 10, 9, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 260L, new DateTime(2022, 10, 9, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 261L, new DateTime(2022, 10, 9, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 262L, new DateTime(2022, 10, 9, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 263L, new DateTime(2022, 10, 9, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 277L, new DateTime(2022, 10, 9, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 276L, new DateTime(2022, 10, 9, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 275L, new DateTime(2022, 10, 9, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 274L, new DateTime(2022, 10, 9, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 273L, new DateTime(2022, 10, 9, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 272L, new DateTime(2022, 10, 9, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 246L, new DateTime(2022, 10, 9, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 271L, new DateTime(2022, 10, 9, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 269L, new DateTime(2022, 10, 9, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 268L, new DateTime(2022, 10, 9, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 267L, new DateTime(2022, 10, 9, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 266L, new DateTime(2022, 10, 9, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 265L, new DateTime(2022, 10, 9, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 264L, new DateTime(2022, 10, 9, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 270L, new DateTime(2022, 10, 9, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 210L, new DateTime(2022, 10, 8, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 245L, new DateTime(2022, 10, 9, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 243L, new DateTime(2022, 10, 9, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 212L, new DateTime(2022, 10, 8, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 213L, new DateTime(2022, 10, 8, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 214L, new DateTime(2022, 10, 8, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 215L, new DateTime(2022, 10, 8, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 216L, new DateTime(2022, 10, 8, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 217L, new DateTime(2022, 10, 8, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 218L, new DateTime(2022, 10, 8, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 219L, new DateTime(2022, 10, 8, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 220L, new DateTime(2022, 10, 8, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 221L, new DateTime(2022, 10, 8, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 222L, new DateTime(2022, 10, 8, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 223L, new DateTime(2022, 10, 8, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 224L, new DateTime(2022, 10, 8, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 225L, new DateTime(2022, 10, 8, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 226L, new DateTime(2022, 10, 8, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 227L, new DateTime(2022, 10, 8, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 228L, new DateTime(2022, 10, 8, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 242L, new DateTime(2022, 10, 9, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 241L, new DateTime(2022, 10, 9, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 240L, new DateTime(2022, 10, 8, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 239L, new DateTime(2022, 10, 8, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 238L, new DateTime(2022, 10, 8, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 237L, new DateTime(2022, 10, 8, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 244L, new DateTime(2022, 10, 9, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 236L, new DateTime(2022, 10, 8, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 234L, new DateTime(2022, 10, 8, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 233L, new DateTime(2022, 10, 8, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 232L, new DateTime(2022, 10, 8, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 231L, new DateTime(2022, 10, 8, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 230L, new DateTime(2022, 10, 8, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 229L, new DateTime(2022, 10, 8, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 235L, new DateTime(2022, 10, 8, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 278L, new DateTime(2022, 10, 9, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 140L, new DateTime(2022, 10, 6, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 138L, new DateTime(2022, 10, 6, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 37L, new DateTime(2022, 10, 3, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 38L, new DateTime(2022, 10, 3, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 39L, new DateTime(2022, 10, 3, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 40L, new DateTime(2022, 10, 3, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 41L, new DateTime(2022, 10, 4, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 42L, new DateTime(2022, 10, 4, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 43L, new DateTime(2022, 10, 4, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 44L, new DateTime(2022, 10, 4, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 45L, new DateTime(2022, 10, 4, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 46L, new DateTime(2022, 10, 4, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 47L, new DateTime(2022, 10, 4, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 48L, new DateTime(2022, 10, 4, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 49L, new DateTime(2022, 10, 4, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 50L, new DateTime(2022, 10, 4, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 51L, new DateTime(2022, 10, 4, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 52L, new DateTime(2022, 10, 4, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 53L, new DateTime(2022, 10, 4, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 67L, new DateTime(2022, 10, 4, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 66L, new DateTime(2022, 10, 4, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 65L, new DateTime(2022, 10, 4, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 64L, new DateTime(2022, 10, 4, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 63L, new DateTime(2022, 10, 4, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 62L, new DateTime(2022, 10, 4, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 36L, new DateTime(2022, 10, 3, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 61L, new DateTime(2022, 10, 4, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 59L, new DateTime(2022, 10, 4, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 58L, new DateTime(2022, 10, 4, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 57L, new DateTime(2022, 10, 4, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 56L, new DateTime(2022, 10, 4, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 55L, new DateTime(2022, 10, 4, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 54L, new DateTime(2022, 10, 4, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 60L, new DateTime(2022, 10, 4, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 68L, new DateTime(2022, 10, 4, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 35L, new DateTime(2022, 10, 3, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 33L, new DateTime(2022, 10, 3, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 2L, new DateTime(2022, 10, 3, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 3L, new DateTime(2022, 10, 3, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 4L, new DateTime(2022, 10, 3, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 5L, new DateTime(2022, 10, 3, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 6L, new DateTime(2022, 10, 3, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 7L, new DateTime(2022, 10, 3, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 8L, new DateTime(2022, 10, 3, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 9L, new DateTime(2022, 10, 3, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 10L, new DateTime(2022, 10, 3, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 11L, new DateTime(2022, 10, 3, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 12L, new DateTime(2022, 10, 3, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 13L, new DateTime(2022, 10, 3, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 14L, new DateTime(2022, 10, 3, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 15L, new DateTime(2022, 10, 3, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 16L, new DateTime(2022, 10, 3, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 17L, new DateTime(2022, 10, 3, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 18L, new DateTime(2022, 10, 3, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 32L, new DateTime(2022, 10, 3, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 31L, new DateTime(2022, 10, 3, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 30L, new DateTime(2022, 10, 3, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 29L, new DateTime(2022, 10, 3, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 28L, new DateTime(2022, 10, 3, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 27L, new DateTime(2022, 10, 3, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 34L, new DateTime(2022, 10, 3, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 26L, new DateTime(2022, 10, 3, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 24L, new DateTime(2022, 10, 3, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 23L, new DateTime(2022, 10, 3, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 22L, new DateTime(2022, 10, 3, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 21L, new DateTime(2022, 10, 3, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 20L, new DateTime(2022, 10, 3, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 19L, new DateTime(2022, 10, 3, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 25L, new DateTime(2022, 10, 3, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 139L, new DateTime(2022, 10, 6, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 69L, new DateTime(2022, 10, 4, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 71L, new DateTime(2022, 10, 4, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 107L, new DateTime(2022, 10, 5, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 108L, new DateTime(2022, 10, 5, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 109L, new DateTime(2022, 10, 5, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 110L, new DateTime(2022, 10, 5, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 111L, new DateTime(2022, 10, 5, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 112L, new DateTime(2022, 10, 5, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 113L, new DateTime(2022, 10, 5, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 114L, new DateTime(2022, 10, 5, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 115L, new DateTime(2022, 10, 5, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 116L, new DateTime(2022, 10, 5, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 117L, new DateTime(2022, 10, 5, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 118L, new DateTime(2022, 10, 5, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 119L, new DateTime(2022, 10, 5, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 120L, new DateTime(2022, 10, 5, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 121L, new DateTime(2022, 10, 6, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 122L, new DateTime(2022, 10, 6, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 123L, new DateTime(2022, 10, 6, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 137L, new DateTime(2022, 10, 6, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 136L, new DateTime(2022, 10, 6, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 135L, new DateTime(2022, 10, 6, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 134L, new DateTime(2022, 10, 6, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 133L, new DateTime(2022, 10, 6, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 132L, new DateTime(2022, 10, 6, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 106L, new DateTime(2022, 10, 5, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 131L, new DateTime(2022, 10, 6, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 129L, new DateTime(2022, 10, 6, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 128L, new DateTime(2022, 10, 6, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 127L, new DateTime(2022, 10, 6, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 126L, new DateTime(2022, 10, 6, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 125L, new DateTime(2022, 10, 6, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 124L, new DateTime(2022, 10, 6, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 130L, new DateTime(2022, 10, 6, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 70L, new DateTime(2022, 10, 4, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 105L, new DateTime(2022, 10, 5, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 103L, new DateTime(2022, 10, 5, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 72L, new DateTime(2022, 10, 4, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 73L, new DateTime(2022, 10, 4, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 74L, new DateTime(2022, 10, 4, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 75L, new DateTime(2022, 10, 4, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 76L, new DateTime(2022, 10, 4, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 77L, new DateTime(2022, 10, 4, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 78L, new DateTime(2022, 10, 4, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 79L, new DateTime(2022, 10, 4, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 80L, new DateTime(2022, 10, 4, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 81L, new DateTime(2022, 10, 5, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 82L, new DateTime(2022, 10, 5, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 83L, new DateTime(2022, 10, 5, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 84L, new DateTime(2022, 10, 5, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 85L, new DateTime(2022, 10, 5, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 86L, new DateTime(2022, 10, 5, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 87L, new DateTime(2022, 10, 5, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 88L, new DateTime(2022, 10, 5, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 102L, new DateTime(2022, 10, 5, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 101L, new DateTime(2022, 10, 5, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 100L, new DateTime(2022, 10, 5, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 99L, new DateTime(2022, 10, 5, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 98L, new DateTime(2022, 10, 5, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 97L, new DateTime(2022, 10, 5, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 104L, new DateTime(2022, 10, 5, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 96L, new DateTime(2022, 10, 5, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 94L, new DateTime(2022, 10, 5, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 93L, new DateTime(2022, 10, 5, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 92L, new DateTime(2022, 10, 5, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 91L, new DateTime(2022, 10, 5, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 90L, new DateTime(2022, 10, 5, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 89L, new DateTime(2022, 10, 5, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 95L, new DateTime(2022, 10, 5, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 279L, new DateTime(2022, 10, 9, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 280L, new DateTime(2022, 10, 9, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 281L, new DateTime(2022, 10, 10, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 458L, new DateTime(2022, 10, 14, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 459L, new DateTime(2022, 10, 14, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 460L, new DateTime(2022, 10, 14, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 461L, new DateTime(2022, 10, 14, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 462L, new DateTime(2022, 10, 14, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 463L, new DateTime(2022, 10, 14, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 464L, new DateTime(2022, 10, 14, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 465L, new DateTime(2022, 10, 14, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 466L, new DateTime(2022, 10, 14, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 467L, new DateTime(2022, 10, 14, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 468L, new DateTime(2022, 10, 14, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 469L, new DateTime(2022, 10, 14, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 470L, new DateTime(2022, 10, 14, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 471L, new DateTime(2022, 10, 14, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 472L, new DateTime(2022, 10, 14, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 473L, new DateTime(2022, 10, 14, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 474L, new DateTime(2022, 10, 14, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 488L, new DateTime(2022, 10, 15, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 487L, new DateTime(2022, 10, 15, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 486L, new DateTime(2022, 10, 15, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 485L, new DateTime(2022, 10, 15, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 484L, new DateTime(2022, 10, 15, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 483L, new DateTime(2022, 10, 15, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 457L, new DateTime(2022, 10, 14, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 482L, new DateTime(2022, 10, 15, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 480L, new DateTime(2022, 10, 14, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 479L, new DateTime(2022, 10, 14, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 478L, new DateTime(2022, 10, 14, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 477L, new DateTime(2022, 10, 14, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 476L, new DateTime(2022, 10, 14, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 475L, new DateTime(2022, 10, 14, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 481L, new DateTime(2022, 10, 15, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 489L, new DateTime(2022, 10, 15, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 456L, new DateTime(2022, 10, 14, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 454L, new DateTime(2022, 10, 14, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 423L, new DateTime(2022, 10, 13, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 424L, new DateTime(2022, 10, 13, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 425L, new DateTime(2022, 10, 13, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 426L, new DateTime(2022, 10, 13, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 427L, new DateTime(2022, 10, 13, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 428L, new DateTime(2022, 10, 13, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 429L, new DateTime(2022, 10, 13, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 430L, new DateTime(2022, 10, 13, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 431L, new DateTime(2022, 10, 13, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 432L, new DateTime(2022, 10, 13, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 433L, new DateTime(2022, 10, 13, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 434L, new DateTime(2022, 10, 13, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 435L, new DateTime(2022, 10, 13, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 436L, new DateTime(2022, 10, 13, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 437L, new DateTime(2022, 10, 13, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 438L, new DateTime(2022, 10, 13, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 439L, new DateTime(2022, 10, 13, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 453L, new DateTime(2022, 10, 14, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 452L, new DateTime(2022, 10, 14, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 451L, new DateTime(2022, 10, 14, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 450L, new DateTime(2022, 10, 14, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 449L, new DateTime(2022, 10, 14, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 448L, new DateTime(2022, 10, 14, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 455L, new DateTime(2022, 10, 14, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 447L, new DateTime(2022, 10, 14, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 445L, new DateTime(2022, 10, 14, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 444L, new DateTime(2022, 10, 14, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 443L, new DateTime(2022, 10, 14, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 442L, new DateTime(2022, 10, 14, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 441L, new DateTime(2022, 10, 14, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 440L, new DateTime(2022, 10, 13, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 446L, new DateTime(2022, 10, 14, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 422L, new DateTime(2022, 10, 13, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 490L, new DateTime(2022, 10, 15, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 492L, new DateTime(2022, 10, 15, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 528L, new DateTime(2022, 10, 16, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 529L, new DateTime(2022, 10, 16, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 530L, new DateTime(2022, 10, 16, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 531L, new DateTime(2022, 10, 16, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 532L, new DateTime(2022, 10, 16, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 533L, new DateTime(2022, 10, 16, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 534L, new DateTime(2022, 10, 16, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 535L, new DateTime(2022, 10, 16, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 536L, new DateTime(2022, 10, 16, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 537L, new DateTime(2022, 10, 16, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 538L, new DateTime(2022, 10, 16, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 539L, new DateTime(2022, 10, 16, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 540L, new DateTime(2022, 10, 16, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 541L, new DateTime(2022, 10, 16, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 542L, new DateTime(2022, 10, 16, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 543L, new DateTime(2022, 10, 16, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 544L, new DateTime(2022, 10, 16, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 558L, new DateTime(2022, 10, 16, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 557L, new DateTime(2022, 10, 16, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 556L, new DateTime(2022, 10, 16, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 555L, new DateTime(2022, 10, 16, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 554L, new DateTime(2022, 10, 16, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 553L, new DateTime(2022, 10, 16, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 527L, new DateTime(2022, 10, 16, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 552L, new DateTime(2022, 10, 16, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 550L, new DateTime(2022, 10, 16, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 549L, new DateTime(2022, 10, 16, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 548L, new DateTime(2022, 10, 16, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 547L, new DateTime(2022, 10, 16, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 546L, new DateTime(2022, 10, 16, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 545L, new DateTime(2022, 10, 16, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 551L, new DateTime(2022, 10, 16, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 491L, new DateTime(2022, 10, 15, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 526L, new DateTime(2022, 10, 16, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 524L, new DateTime(2022, 10, 16, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 493L, new DateTime(2022, 10, 15, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 494L, new DateTime(2022, 10, 15, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 495L, new DateTime(2022, 10, 15, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 496L, new DateTime(2022, 10, 15, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 497L, new DateTime(2022, 10, 15, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 498L, new DateTime(2022, 10, 15, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 499L, new DateTime(2022, 10, 15, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 500L, new DateTime(2022, 10, 15, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 501L, new DateTime(2022, 10, 15, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 502L, new DateTime(2022, 10, 15, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 503L, new DateTime(2022, 10, 15, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 504L, new DateTime(2022, 10, 15, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 505L, new DateTime(2022, 10, 15, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 506L, new DateTime(2022, 10, 15, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 507L, new DateTime(2022, 10, 15, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 508L, new DateTime(2022, 10, 15, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 509L, new DateTime(2022, 10, 15, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 523L, new DateTime(2022, 10, 16, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 522L, new DateTime(2022, 10, 16, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 521L, new DateTime(2022, 10, 16, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 520L, new DateTime(2022, 10, 15, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 519L, new DateTime(2022, 10, 15, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 518L, new DateTime(2022, 10, 15, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 525L, new DateTime(2022, 10, 16, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 517L, new DateTime(2022, 10, 15, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 515L, new DateTime(2022, 10, 15, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 514L, new DateTime(2022, 10, 15, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 513L, new DateTime(2022, 10, 15, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 512L, new DateTime(2022, 10, 15, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 511L, new DateTime(2022, 10, 15, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 510L, new DateTime(2022, 10, 15, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 516L, new DateTime(2022, 10, 15, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 421L, new DateTime(2022, 10, 13, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 420L, new DateTime(2022, 10, 13, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 419L, new DateTime(2022, 10, 13, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 317L, new DateTime(2022, 10, 10, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 318L, new DateTime(2022, 10, 10, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 319L, new DateTime(2022, 10, 10, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 320L, new DateTime(2022, 10, 10, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 321L, new DateTime(2022, 10, 11, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 322L, new DateTime(2022, 10, 11, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 323L, new DateTime(2022, 10, 11, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 324L, new DateTime(2022, 10, 11, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 325L, new DateTime(2022, 10, 11, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 326L, new DateTime(2022, 10, 11, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 327L, new DateTime(2022, 10, 11, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 328L, new DateTime(2022, 10, 11, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 329L, new DateTime(2022, 10, 11, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 330L, new DateTime(2022, 10, 11, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 331L, new DateTime(2022, 10, 11, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 332L, new DateTime(2022, 10, 11, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 333L, new DateTime(2022, 10, 11, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 347L, new DateTime(2022, 10, 11, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 346L, new DateTime(2022, 10, 11, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 345L, new DateTime(2022, 10, 11, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 344L, new DateTime(2022, 10, 11, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 343L, new DateTime(2022, 10, 11, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 342L, new DateTime(2022, 10, 11, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 316L, new DateTime(2022, 10, 10, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 341L, new DateTime(2022, 10, 11, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 339L, new DateTime(2022, 10, 11, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 338L, new DateTime(2022, 10, 11, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 337L, new DateTime(2022, 10, 11, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 336L, new DateTime(2022, 10, 11, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 335L, new DateTime(2022, 10, 11, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 334L, new DateTime(2022, 10, 11, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 340L, new DateTime(2022, 10, 11, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 348L, new DateTime(2022, 10, 11, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 315L, new DateTime(2022, 10, 10, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 313L, new DateTime(2022, 10, 10, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 282L, new DateTime(2022, 10, 10, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 283L, new DateTime(2022, 10, 10, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 284L, new DateTime(2022, 10, 10, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 285L, new DateTime(2022, 10, 10, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 286L, new DateTime(2022, 10, 10, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 287L, new DateTime(2022, 10, 10, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 288L, new DateTime(2022, 10, 10, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 289L, new DateTime(2022, 10, 10, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 290L, new DateTime(2022, 10, 10, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 291L, new DateTime(2022, 10, 10, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 292L, new DateTime(2022, 10, 10, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 293L, new DateTime(2022, 10, 10, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 294L, new DateTime(2022, 10, 10, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 295L, new DateTime(2022, 10, 10, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 296L, new DateTime(2022, 10, 10, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 297L, new DateTime(2022, 10, 10, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 298L, new DateTime(2022, 10, 10, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 312L, new DateTime(2022, 10, 10, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 311L, new DateTime(2022, 10, 10, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 310L, new DateTime(2022, 10, 10, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 309L, new DateTime(2022, 10, 10, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 308L, new DateTime(2022, 10, 10, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 307L, new DateTime(2022, 10, 10, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 314L, new DateTime(2022, 10, 10, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 306L, new DateTime(2022, 10, 10, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 304L, new DateTime(2022, 10, 10, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 303L, new DateTime(2022, 10, 10, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 302L, new DateTime(2022, 10, 10, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 301L, new DateTime(2022, 10, 10, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 300L, new DateTime(2022, 10, 10, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 299L, new DateTime(2022, 10, 10, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 305L, new DateTime(2022, 10, 10, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 349L, new DateTime(2022, 10, 11, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 350L, new DateTime(2022, 10, 11, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 351L, new DateTime(2022, 10, 11, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 388L, new DateTime(2022, 10, 12, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 389L, new DateTime(2022, 10, 12, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 390L, new DateTime(2022, 10, 12, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 391L, new DateTime(2022, 10, 12, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 392L, new DateTime(2022, 10, 12, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 393L, new DateTime(2022, 10, 12, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 394L, new DateTime(2022, 10, 12, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 395L, new DateTime(2022, 10, 12, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 396L, new DateTime(2022, 10, 12, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 397L, new DateTime(2022, 10, 12, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 398L, new DateTime(2022, 10, 12, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 399L, new DateTime(2022, 10, 12, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 400L, new DateTime(2022, 10, 12, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 401L, new DateTime(2022, 10, 13, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 402L, new DateTime(2022, 10, 13, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 403L, new DateTime(2022, 10, 13, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 404L, new DateTime(2022, 10, 13, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 418L, new DateTime(2022, 10, 13, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 417L, new DateTime(2022, 10, 13, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 416L, new DateTime(2022, 10, 13, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 415L, new DateTime(2022, 10, 13, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 414L, new DateTime(2022, 10, 13, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 413L, new DateTime(2022, 10, 13, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 387L, new DateTime(2022, 10, 12, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 412L, new DateTime(2022, 10, 13, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 410L, new DateTime(2022, 10, 13, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 409L, new DateTime(2022, 10, 13, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 408L, new DateTime(2022, 10, 13, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 407L, new DateTime(2022, 10, 13, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 406L, new DateTime(2022, 10, 13, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 405L, new DateTime(2022, 10, 13, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 411L, new DateTime(2022, 10, 13, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 386L, new DateTime(2022, 10, 12, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 385L, new DateTime(2022, 10, 12, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 384L, new DateTime(2022, 10, 12, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 365L, new DateTime(2022, 10, 12, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 364L, new DateTime(2022, 10, 12, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 363L, new DateTime(2022, 10, 12, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 362L, new DateTime(2022, 10, 12, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 361L, new DateTime(2022, 10, 12, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 360L, new DateTime(2022, 10, 11, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 366L, new DateTime(2022, 10, 12, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 359L, new DateTime(2022, 10, 11, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 357L, new DateTime(2022, 10, 11, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 356L, new DateTime(2022, 10, 11, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 355L, new DateTime(2022, 10, 11, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 354L, new DateTime(2022, 10, 11, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 353L, new DateTime(2022, 10, 11, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 352L, new DateTime(2022, 10, 11, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 358L, new DateTime(2022, 10, 11, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 1119L, new DateTime(2022, 10, 30, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 367L, new DateTime(2022, 10, 12, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 369L, new DateTime(2022, 10, 12, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 383L, new DateTime(2022, 10, 12, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 382L, new DateTime(2022, 10, 12, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 381L, new DateTime(2022, 10, 12, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 380L, new DateTime(2022, 10, 12, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 379L, new DateTime(2022, 10, 12, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 378L, new DateTime(2022, 10, 12, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 368L, new DateTime(2022, 10, 12, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 377L, new DateTime(2022, 10, 12, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 375L, new DateTime(2022, 10, 12, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 374L, new DateTime(2022, 10, 12, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 373L, new DateTime(2022, 10, 12, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 372L, new DateTime(2022, 10, 12, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 371L, new DateTime(2022, 10, 12, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 370L, new DateTime(2022, 10, 12, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 376L, new DateTime(2022, 10, 12, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 1120L, new DateTime(2022, 10, 30, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L);

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
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L);

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
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 31L);

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
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 38L);

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
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 42L);

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
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 48L);

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
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 59L);

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
                keyValue: 62L);

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
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 66L);

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
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 75L);

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
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 85L);

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
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 92L);

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
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 97L);

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
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 101L);

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
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 105L);

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
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 113L);

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
                keyValue: 137L);

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
                keyValue: 140L);

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
                keyValue: 143L);

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
                keyValue: 146L);

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
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 154L);

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
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 158L);

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
                keyValue: 164L);

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
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 168L);

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
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 176L);

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
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 181L);

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
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 188L);

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
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 192L);

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
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 196L);

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

            migrationBuilder.AddColumn<string>(
                name: "MovieName",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
