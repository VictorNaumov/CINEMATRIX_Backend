using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class MovieCommentConfiguration : IEntityTypeConfiguration<MovieComment>
    {
        public void Configure(EntityTypeBuilder<MovieComment> builder)
        {
            long id = 1;

            builder.HasData
            (
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 19995,
                    ProfileId = 1,
                    Text = "I absolutely loved this movie! The visual effects were stunning and the story was captivating.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 19995,
                    ProfileId = 2,
                    Text = "I agree, the special effects in this movie were groundbreaking. The plot was a bit predictable, but overall it was an enjoyable film.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 19995,
                    ProfileId = 2,
                    Text = "I was really disappointed in this movie. The plot was too predictable and the acting was subpar.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 19995,
                    ProfileId = 1,
                    Text = "I thought the plot was interesting and the acting was solid. Definitely worth a watch!",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 19995,
                    ProfileId = 2,
                    Text = "I was blown away by the visuals in this film. The story was a bit weak, but overall it was a great movie experience.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 19995,
                    ProfileId = 1,
                    Text = "This movie was amazing! The special effects were unbelievable.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 19995,
                    ProfileId = 2,
                    Text = "I thought the plot was a bit predictable, but the action scenes were great.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 19995,
                    ProfileId = 1,
                    Text = "I totally agree about the special effects, they were some of the best I've ever seen in a movie.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = id - 2,
                    MovieId = 19995,
                    ProfileId = 2,
                    Text = "I thought the plot was actually really interesting and kept me engaged throughout the movie.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 19995,
                    ProfileId = 1,
                    Text = "I wasn't a huge fan of the movie overall. It was okay, but not one of my favorites.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 526896,
                    ProfileId = 1,
                    Text = "This movie was really good! I really enjoyed the action and special effects.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = null,
                    MovieId = 526896,
                    ProfileId = 2,
                    Text = "I thought the acting was a bit weak, but the plot was intriguing.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = id - 3,
                    MovieId = 526896,
                    ProfileId = 3,
                    Text = "I agree, the action scenes were definitely a highlight of the film.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = id - 3,
                    MovieId = 526896,
                    ProfileId = 2,
                    Text = "I disagree, I thought the acting was top notch and really brought the characters to life.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                },
                new MovieComment
                {
                    Id = id++,
                    ParentCommentId = id - 2,
                    MovieId = 526896,
                    ProfileId = 1,
                    Text = "I have to agree with the previous comment, the acting was definitely one of the strengths of this film.",
                    DateTime = DateTime.Now,
                    IsDeleted = false
                }
            );
        }
    }
}

