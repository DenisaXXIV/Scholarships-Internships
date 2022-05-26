import { Category } from "./category.model";

export interface Pin {
    id: string;
    name: string;
    path: string;
    category: Category['id'];
}
