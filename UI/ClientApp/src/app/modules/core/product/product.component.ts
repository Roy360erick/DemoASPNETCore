import { Component, OnInit } from '@angular/core';
import { ProductV1 } from 'src/app/models/product';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {

  products:ProductV1[]=[]; 

  constructor(private productService:ProductService) { }

  ngOnInit(): void {
    this.productService.get().subscribe((res:any) => {
      if(res != null) this.products = res.listado; 
    });
  }

}
