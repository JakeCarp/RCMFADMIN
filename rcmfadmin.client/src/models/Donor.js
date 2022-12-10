export class Donor {
  constructor(data) {
    this.id = data.id;
    this.name = data.name
    this.email = data.email
    this.amount = data.amount
    this.createdAt = data.createdAt
    this.updatedAt = data.updatedAt
  }
}

