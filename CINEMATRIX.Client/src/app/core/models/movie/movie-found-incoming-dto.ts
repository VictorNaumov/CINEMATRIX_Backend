import { GenreFoundIncomingDto } from "../genre/genre-found-incoming-dto"
import { ImageDto } from "../extends/image-dto"
import { MovieCreditsDto } from "../extends/movie-credits-dto"
import { VideoDto } from "../extends/video-dto"

export interface MovieFoundIncomingDto {
  id: number,
  title: string,
  overview: string,
  adult: boolean,
  budget: number,
  originalLanguage: string,
  originalTitle: string,
  popularity: number,
  posterPath: string,
  releaseDate: string,
  runtime: number,
  status: string,
  tagline: string,
  backdropPath: string
  video: boolean,
  voteAverage: number,
  voteCount: number,
  genres: GenreFoundIncomingDto[],
  videos: VideoDto[],
  images: ImageDto[],
  credits: MovieCreditsDto[]
}
