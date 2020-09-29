import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { ProductModel } from "../models/product.model";

@Injectable({ providedIn: "root" })
export class AppProductService {
    private readonly url = "products";

    constructor(private readonly http: HttpClient) { }

    add(model: ProductModel) {
        return this.http.post<number>(this.url, model);
    }

    delete(id: number) {
        return this.http.delete(`${this.url}/${id}`);
    }

    get(id: number) {
        return this.http.get<ProductModel>(`${this.url}/${id}`);
    }

    list() {
        return this.http.get<ProductModel[]>(this.url);
    }

    update(model: ProductModel) {
        return this.http.put(`${this.url}/${model.id}`, model);
    }
}
