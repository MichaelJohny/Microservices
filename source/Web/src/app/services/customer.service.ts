import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { CustomerModel } from "../models/customer.model";

@Injectable({ providedIn: "root" })
export class AppCustomerService {
    private readonly url = "customers";

    constructor(private readonly http: HttpClient) { }

    add(model: CustomerModel) {
        return this.http.post<number>(this.url, model);
    }

    delete(id: number) {
        return this.http.delete(`${this.url}/${id}`);
    }

    get(id: number) {
        return this.http.get<CustomerModel>(`${this.url}/${id}`);
    }

    list() {
        return this.http.get<CustomerModel[]>(this.url);
    }

    update(model: CustomerModel) {
        return this.http.put(`${this.url}/${model.id}`, model);
    }
}
