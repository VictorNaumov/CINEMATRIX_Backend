import { PageSettings } from "./page-settings";

export interface PageDTOBase extends PageSettings {
  sortDirection?: string,
  sortProperty?: string
}
