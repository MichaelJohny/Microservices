import { Routes } from "@angular/router";
import { AppLayoutComponent } from "./layouts/layout/layout.component";

export const ROUTES: Routes = [
    {
        path: "",
        component: AppLayoutComponent,
        children: [
            { path: "", loadChildren: () => import("./views/home/home.module").then((x) => x.AppHomeModule) }
        ]
    },
    { path: "**", redirectTo: "" }
];
