import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LivrariaListComponent } from './livraria/livraria-list/livraria-list.component';
import { LivrariaAddComponent } from './livraria/livraria-add/livraria-add.component';
import { ReactiveFormsModule } from '@angular/forms';
import { livrariaService } from './services/livraria.service';
import { LivrariaComponent } from './livraria/livraria.component';

@NgModule({
  declarations: [
    AppComponent,
    LivrariaListComponent,
    LivrariaAddComponent,
    LivrariaComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [ livrariaService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
