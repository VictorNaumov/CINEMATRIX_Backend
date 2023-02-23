import { PageDTOBase } from "src/app/core/models/page-abstractions/paged-dto-base";

export function setBasicPageParams<T extends PageDTOBase>(params: T, page?: number) : T {
  params.page = page ? page : 0;
  params.pageSize = 20;
  params.sortDirection = 'asc';
  params.sortProperty = 'id';

  return params;
}
