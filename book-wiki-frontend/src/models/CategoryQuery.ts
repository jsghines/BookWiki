import CategoryItemType from "../types/category-item";
import CategoryQueryType from "../types/category-query";

export default class CategoryQueryModel implements CategoryQueryType {
  categories: CategoryItemType[] = [];
}
