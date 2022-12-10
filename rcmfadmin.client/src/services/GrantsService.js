import { AppState } from "../AppState.js";
import { Grant } from "../models/Grant.js";
import { mySQL } from "./AxiosService.js";

class GrantsService {
  async getGrants() {
    const res = await mySQL.get("grants");
    AppState.grants = res.data.map((g) => new Grant(g));
  }
  async getGrantById(grantId) {
    const res = await mySQL.get(`grants/${grantId}`);
  }

  async createGrant(grantData) {
    const res = await mySQL.post("grants", grantData);
    let newGrant = new Grant(res.data);

    AppState.grants.push(newGrant);
  }

  async deleteGrant(grantId) {
    await mySQL.delete(`grants/${grantId}`);
    AppState.grants.filter((g) => g.id != grantId);
  }

  async editGrant(grantData){
    const res = await mySQL.put('grants',grantData)
    let updatedGrant = new Grant(res.data)
      let index = AppState.grants.findIndex((g) => {
          g.id == grantData.id;
        });
    
        AppState.grants.splice(index, 1);
        AppState.grants.push(updatedGrant)
  }
}
export const grantsService = new GrantsService();
