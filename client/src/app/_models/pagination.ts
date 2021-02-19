export interface Pagination{
    currentPage: number;
    itemsPerPag: number;
    totalItems: number;
    totalPages: number;

}
export class PaginatedResult<T>{
    result: T;
    pagination: Pagination;

}