import { HttpClientModule } from "@angular/common/http";
import { ErrorHandler, NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { AppComponent } from "./app.component";
import { AppErrorHandler } from "./app.error.handler";
import { ROUTES } from "./app.routes";
import { AppLayoutsModule } from "./layouts/layouts.module";

@NgModule({
    bootstrap: [AppComponent],
    declarations: [AppComponent],
    imports: [
        BrowserModule,
        HttpClientModule,
        RouterModule.forRoot(ROUTES),
        AppLayoutsModule
    ],
    providers: [
        { provide: ErrorHandler, useClass: AppErrorHandler }
    ]
})
export class AppModule { }
