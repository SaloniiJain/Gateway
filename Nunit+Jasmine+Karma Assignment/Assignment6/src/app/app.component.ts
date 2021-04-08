import { Component } from '@angular/core';
import { Product } from 'src/models/product';
import { CRUDService } from 'src/shared/crud.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Assigment6';
  constructor(private service:CRUDService){}

  async GetAllProducts():Promise<Product[]>{
    return await this.service.getProducts();
  }
  async GetSingleProduct(id:number):Promise<Product>{
    return await this.service.getProduct(id);
  }
  async AddProduct(model:Product):Promise<Product[]>{
    return await this.service.createProduct({id:5,category:"Vehicles",productName:"Car",price:120000});
  }
  async UpdateProduct(model:Product):Promise<Product[]>{
    return await this.service.updateProduct({id:3,category:"Vehicles",productName:"Bike",price:50000})
  }
  async RemoveProduct(id:number):Promise<Product[]>{
    return await this.service.deleteProduct(id);
  }
}
